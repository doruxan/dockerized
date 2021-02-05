using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Logistics.Business.Core.Interfaces.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Logistics.Business.Core.Interfaces
{
    public class CommandBus : ICommandBus
    {
        protected readonly IServiceProvider serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        [DebuggerStepThrough]
        public void Send<T>(T command) where T : ICommand
        {
            var handler = serviceProvider.GetService<ICommandHandler<T>>();

            if (handler == null)
                throw new Exception(string.Format("Command handler not found for command type {0}", nameof(command)));

            command.Result = true;

            try
            {
                handler.Handle(command);
            }
            catch (Exception)
            {
                command.Result = false;
                throw;
            }
        }

        [DebuggerStepThrough]
        public async Task SendAsync<T>(T command) where T : IAsyncCommand
        {
            var handler = serviceProvider.GetService<ICommandHandler<T>>();

            if (handler == null)
                throw new Exception(string.Format("Command handler not found for command type {0}", nameof(command)));

            if (!(handler is IAsyncCommandHandler<T>))
                throw new Exception(string.Format("Command handler {0} does not support async", nameof(handler)));

            command.Result = true;

            try
            {
                await (handler as IAsyncCommandHandler<T>).HandleAsync(command).ConfigureAwait(false);
            }
            catch (Exception)
            {
                command.Result = false;
                throw;
            }
        }
    }
}

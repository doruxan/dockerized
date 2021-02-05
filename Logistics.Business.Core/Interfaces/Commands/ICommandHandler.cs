using System;
using System.Threading.Tasks;

namespace Logistics.Business.Core.Interfaces.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }

    public interface IAsyncCommandHandler<T> : ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}

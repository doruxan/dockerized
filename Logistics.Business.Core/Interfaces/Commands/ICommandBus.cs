using System.Threading.Tasks;

namespace Logistics.Business.Core.Interfaces.Commands
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
        Task SendAsync<T>(T command) where T : IAsyncCommand;
    }
}

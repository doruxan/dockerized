using System;
namespace Logistics.Business.Core.Interfaces.Commands
{
    public interface ICommand
    {
        bool Result { get; set; }
    }

    public interface IAsyncCommand : ICommand { }
}

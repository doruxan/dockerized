using System;
namespace Logistics.Business.Core.Interfaces.Queries
{
    public interface IQuery<TResult> where TResult : class
    {

    }

    public interface IAsyncQuery<TResult> : IQuery<TResult> where TResult : class
    {

    }
}

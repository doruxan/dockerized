using System;
using System.Threading.Tasks;

namespace Logistics.Business.Core.Interfaces.Queries
{
    public interface IQueryExecutor<TQuery, TResult> where TQuery : class, IQuery<TResult> where TResult : class
    {
        /// <summary>
        /// If called 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        TResult Execute(TQuery query);
    }

    public interface IAsyncQueryExecutor<TQuery, TResult> : IQueryExecutor<TQuery, TResult> where TQuery : class, IQuery<TResult> where TResult : class
    {
        Task<TResult> ExecuteAsync(TQuery query);
    }
}

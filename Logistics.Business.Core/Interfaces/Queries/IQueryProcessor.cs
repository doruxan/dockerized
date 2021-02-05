using System;
using System.Threading.Tasks;

namespace Logistics.Business.Core.Interfaces.Queries
{
    public interface IQueryProcessor
    {
        /// <summary>
        /// This method could cause deadlocks. If you have to use it, please be careful. Consider using ProcessAsync with IAsyncQuery objects. 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        TResult Process<TResult>(IQuery<TResult> query) where TResult : class;

        Task<TResult> ProcessAsync<TResult>(IAsyncQuery<TResult> query) where TResult : class;
    }
}

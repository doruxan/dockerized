using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Logistics.Business.Core.Interfaces.Queries;

namespace Logistics.Business.Core.Interfaces
{
    public class QueryProcessor : IQueryProcessor
    {
        protected readonly IServiceProvider serviceProvider;

        public QueryProcessor(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        [DebuggerStepThrough]
        public TResult Process<TResult>(IQuery<TResult> query) where TResult : class
        {
            var handlerType = typeof(IQueryExecutor<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var executor = serviceProvider.GetService(handlerType);

            if (executor == null)
                throw new Exception(string.Format("Query executor not found for query type {0}", query.GetType().Name));

            return (executor as dynamic).Execute(query as dynamic);

        }

        [DebuggerStepThrough]
        public async Task<TResult> ProcessAsync<TResult>(IAsyncQuery<TResult> query) where TResult : class
        {
            var handlerType = typeof(IAsyncQueryExecutor<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var executor = serviceProvider.GetService(handlerType);

            if (executor == null)
                throw new Exception(string.Format("Query executor not found for query type {0}", query.GetType().Name));

            return await (executor as dynamic).ExecuteAsync(query as dynamic);
        }
    }
}

using System;
using System.Linq;
using System.Reflection;
using Logistics.Business.Core.Interfaces;
using Logistics.Business.Core.Interfaces.Commands;
using Logistics.Business.Core.Interfaces.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Logistics.Business
{
    public class BusinessBootstrapper
    {
        public static void RegisterDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICommandBus, CommandBus>();
            serviceCollection.AddTransient<IQueryProcessor, QueryProcessor>();
            RegisterQueryExecutors(serviceCollection);
            RegisterCommandHandlers(serviceCollection);
        }

        private static void RegisterCommandHandlers(IServiceCollection serviceCollection)
        {
            var handlers = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => x.GetInterfaces()
                .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(ICommandHandler<>))).ToList();

            foreach (var handler in handlers)
            {
                var interfaces = handler.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    serviceCollection.AddTransient(@interface, handler);
                }
            }
        }

        private static void RegisterQueryExecutors(IServiceCollection serviceCollection)
        {
            var executors = Assembly.GetExecutingAssembly().GetTypes()
              .Where(x => x.GetInterfaces()
                  .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(IAsyncQueryExecutor<,>))).ToList();

            foreach (var executor in executors)
            {
                var interfaces = executor.GetInterfaces();
                foreach (var @interface in interfaces)
                {
                    serviceCollection.AddTransient(@interface, executor);
                }
            }
        }
    }
}

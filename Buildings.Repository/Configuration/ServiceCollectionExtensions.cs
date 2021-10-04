using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;
using Buildings.Domain.Handlers;
using Buildings.Domain.Handlers.Implementation;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Buildings.Domain.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));

            var mapper = configuration.CreateMapper();

            serviceCollection.AddSingleton(mapper);
        }

        public static void AddHandlers(this IServiceCollection serviceCollection)
        {
            var types = GetHandlerTypes();
            foreach (Type type in types)
            {
                var intrface = type.GetInterface($"I{type.Name}");

                serviceCollection.AddTransient(intrface, type);
            }
        }

        static IEnumerable<Type> GetHandlerTypes()
        {
            var type = typeof(BaseHandler);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p))
                .Where(p => p.Name != "BaseHandler");
        }

    }
}

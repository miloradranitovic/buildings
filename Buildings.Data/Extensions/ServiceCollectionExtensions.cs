using Buildings.Data.Repository;
using Buildings.Domain.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Buildings.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityRepository(this IServiceCollection services)
        {
            var types = GetIEntityTypes();
            foreach(Type type in types)
            {
                var ctorType = typeof(IEntityRepository<>).MakeGenericType(type);
                var implementationType = typeof(EntityRepository<>).MakeGenericType(type);

                services.AddTransient(ctorType, implementationType);
            }
        }
        static IEnumerable<Type> GetIEntityTypes()
        {
            var type = typeof(IEntity);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p))
                .Where(p => p.Name != "IEntity");
        }
    }
}

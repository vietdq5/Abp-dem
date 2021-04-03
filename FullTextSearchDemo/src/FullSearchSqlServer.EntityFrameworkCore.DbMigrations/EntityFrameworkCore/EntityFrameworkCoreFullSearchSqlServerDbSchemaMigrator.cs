using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FullSearchSqlServer.Data;
using Volo.Abp.DependencyInjection;

namespace FullSearchSqlServer.EntityFrameworkCore
{
    public class EntityFrameworkCoreFullSearchSqlServerDbSchemaMigrator
        : IFullSearchSqlServerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFullSearchSqlServerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FullSearchSqlServerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FullSearchSqlServerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FullSearchSqlServer.EntityFrameworkCore
{
    [DependsOn(
        typeof(FullSearchSqlServerEntityFrameworkCoreModule)
        )]
    public class FullSearchSqlServerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FullSearchSqlServerMigrationsDbContext>();
        }
    }
}

using FullSearchSqlServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FullSearchSqlServer.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FullSearchSqlServerEntityFrameworkCoreDbMigrationsModule),
        typeof(FullSearchSqlServerApplicationContractsModule)
        )]
    public class FullSearchSqlServerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

using Volo.Abp.Modularity;

namespace FullSearchSqlServer
{
    [DependsOn(
        typeof(FullSearchSqlServerApplicationModule),
        typeof(FullSearchSqlServerDomainTestModule)
        )]
    public class FullSearchSqlServerApplicationTestModule : AbpModule
    {

    }
}
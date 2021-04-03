using FullSearchSqlServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FullSearchSqlServer
{
    [DependsOn(
        typeof(FullSearchSqlServerEntityFrameworkCoreTestModule)
        )]
    public class FullSearchSqlServerDomainTestModule : AbpModule
    {

    }
}
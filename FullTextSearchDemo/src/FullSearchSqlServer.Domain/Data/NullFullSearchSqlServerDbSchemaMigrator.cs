using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FullSearchSqlServer.Data
{
    /* This is used if database provider does't define
     * IFullSearchSqlServerDbSchemaMigrator implementation.
     */
    public class NullFullSearchSqlServerDbSchemaMigrator : IFullSearchSqlServerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
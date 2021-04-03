using System.Threading.Tasks;

namespace FullSearchSqlServer.Data
{
    public interface IFullSearchSqlServerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

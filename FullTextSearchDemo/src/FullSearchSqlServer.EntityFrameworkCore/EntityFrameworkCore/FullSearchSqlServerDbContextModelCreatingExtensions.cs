using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace FullSearchSqlServer.EntityFrameworkCore
{
    public static class FullSearchSqlServerDbContextModelCreatingExtensions
    {
        public static void ConfigureFullSearchSqlServer(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FullSearchSqlServerConsts.DbTablePrefix + "YourEntities", FullSearchSqlServerConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
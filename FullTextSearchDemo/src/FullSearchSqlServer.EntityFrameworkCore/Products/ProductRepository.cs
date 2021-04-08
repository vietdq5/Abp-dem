using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullSearchSqlServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FullSearchSqlServer.Products
{
    public class ProductRepository : EfCoreRepository<FullSearchSqlServerDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<FullSearchSqlServerDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<Product>> SearchByNameAsync(string name)
        {
            var query = await GetQueryableAsync();
            return await query.Where(s => EF.Functions.FreeText(s.Name.ToLower(), name.ToLower())).ToListAsync();
        }
    }
}
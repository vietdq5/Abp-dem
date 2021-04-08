using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FullSearchSqlServer.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
        Task<List<Product>> SearchByNameAsync(string name);
    }
}
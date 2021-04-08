using FullSearchSqlServer.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FullSearchSqlServer.Products
{
    public interface IProductAppService :
        ICrudAppService<
            ProductDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateProductDto,
            CreateUpdateProductDto>
    {
        Task<IEnumerable<ProductDto>> SearchByNameAsync(string name);
    }
}
using FullSearchSqlServer.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FullSearchSqlServer.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, CreateUpdateProductDto>,
        IProductAppService
    {
        private readonly IProductRepository _repository;

        public ProductAppService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> SearchByNameAsync(string name)
        {
            var items = await _repository.SearchByNameAsync(name);
            return ObjectMapper.Map<List<Product>, List<ProductDto>>(items);
        }
    }
}
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace FullSearchSqlServer.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Currency { get; set; }

        public decimal? OriginalPrice { get; set; }

        public decimal Price { get; set; }

        public int OrderMinQuantity { get; set; }

        public int OrderMaxQuantity { get; set; }
        public virtual string UniqueName { get; protected set; }

        protected Product()
        {
        }

        public Product(
            Guid id,
            string name,
            string currency,
            decimal? originalPrice,
            decimal price,
            int orderMinQuantity,
            int orderMaxQuantity,
            string uniqueName
        ) : base(id)
        {
            Name = name;
            Currency = currency;
            OriginalPrice = originalPrice;
            Price = price;
            OrderMinQuantity = orderMinQuantity;
            OrderMaxQuantity = orderMaxQuantity;
            UniqueName = uniqueName;
        }
    }
}

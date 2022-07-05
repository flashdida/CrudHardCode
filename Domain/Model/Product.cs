using System.Collections.Generic;
using Domain.Model.Base;

namespace Domain.Model
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public decimal Cost { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductAttributeValue> AttributeFieldProducts { get; set; }
    }
}

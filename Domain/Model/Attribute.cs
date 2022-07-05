using System.Collections.Generic;
using Domain.Model.Base;

namespace Domain.Model
{
    public class Attribute : BaseEntity
    {
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductAttributeValue> AttributeFieldProducts { get; set; }
    }
}
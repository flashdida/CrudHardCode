using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.Base;

namespace Domain.Models
{
    public class ProductAttributeValue : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey(nameof(Attribute))]
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
        public string Value { get; set; }
    }
}
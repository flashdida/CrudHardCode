using Domain.Model.Base;

namespace Domain.Model
{
    public class ProductAttributeValue : BaseEntity
    {
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int? AttributeFieldId { get; set; }
        public Attribute Attribute { get; set; }
        public string Value { get; set; }
    }
}
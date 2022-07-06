using Application.Models.Base;

namespace Application.Models;

public class ProductAttributeValueDto : BaseEntityDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int AttributeId { get; set; }
    public string AttributeName { get; set; }
    public string Value { get; set; }
}
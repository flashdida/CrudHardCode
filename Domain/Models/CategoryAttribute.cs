using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.Base;

namespace Domain.Models;

public class CategoryAttribute : BaseEntity
{
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [ForeignKey(nameof(Attribute))]
    public int AttributeId { get; set; }
    public Attribute Attribute { get; set; }
}
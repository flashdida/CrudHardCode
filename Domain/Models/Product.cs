using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.Base;

namespace Domain.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

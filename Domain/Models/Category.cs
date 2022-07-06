using System.Collections.Generic;
using Domain.Models.Base;

namespace Domain.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CategoryAttribute> Attributes { get; set; }
    }
}

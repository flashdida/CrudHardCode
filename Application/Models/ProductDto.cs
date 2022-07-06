using Application.Models.Base;

namespace Application.Models;

public class ProductDto : BaseEntityDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public decimal Cost { get; set; }
    public int? CategoryId { get; set; }
    public string CategoryName { get; set; }
}
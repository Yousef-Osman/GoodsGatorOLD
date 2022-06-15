using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class Product: BaseModel
{
    public Product()
    {
        Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    [Required]
    public int BrandId { get; set; }
    [Required]
    public int ProductTypeId { get; set; }

    public Brand Brand { get; set; }
    public ProductType ProductType { get; set; }
}

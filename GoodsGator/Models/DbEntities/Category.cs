using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class Category : BaseEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}

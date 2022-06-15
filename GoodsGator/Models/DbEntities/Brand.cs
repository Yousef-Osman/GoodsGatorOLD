using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class Brand : BaseModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}

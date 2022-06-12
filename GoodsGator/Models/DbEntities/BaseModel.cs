using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class BaseModel
{
    public BaseModel()
    {
        Id = Guid.NewGuid().ToString();
        CreatedOn = DateTime.Now;
        IsDeleted = false;
    }

    [Key]
    public string Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? LastModifiedOn { get; set; }
    public DateTime? DeletedOn { get; set; }
    public bool IsDeleted { get; set; }
}

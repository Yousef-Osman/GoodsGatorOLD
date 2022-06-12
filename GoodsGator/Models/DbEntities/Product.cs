using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class Product: BaseModel
{
    public int Name { get; set; }
    public int Description { get; set; }
}

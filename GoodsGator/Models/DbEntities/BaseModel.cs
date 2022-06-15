﻿using System.ComponentModel.DataAnnotations;

namespace GoodsGator.Models.DbEntities;

public class BaseModel
{
    public BaseModel()
    {
        CreatedOn = DateTime.Now;
        IsDeleted = false;
    }

    public DateTime CreatedOn { get; set; }
    public DateTime? LastModifiedOn { get; set; }
    public DateTime? DeletedOn { get; set; }
    public bool IsDeleted { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    [Key]
    public Guid uidTuid { get; set; }
    public string strName { get; set; }
    public string strDescription { get; set; }

    public List<Commodity> lstCommodities { get; set; }
}
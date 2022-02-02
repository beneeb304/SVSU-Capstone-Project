using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("name")]
    public string strName { get; set; }
    [Column("description")]
    public string strDescription { get; set; }

    public List<Commodity> lstCommodities { get; set; }
}
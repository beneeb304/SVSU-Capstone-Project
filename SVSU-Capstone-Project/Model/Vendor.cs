using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vendor
{
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("name")]
    public string strName { get; set; }
    [Column("homepage")]
    public string strHomepage { get; set; }
    [Column("description")]
    public string strDescription { get; set; }
    
    public virtual List<VendorItem> lstItemsSold { get; set; }
}
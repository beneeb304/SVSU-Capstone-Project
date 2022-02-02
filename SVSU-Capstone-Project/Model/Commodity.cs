using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Commodity
{
    //properties
    [Key]
    public Guid uidTuid { get; set; }
    [Column("name")]
    public string strName { get; set; }
    [Column("description")]
    public string strDescription { get; set; }
    [Column("features")]
    public string strFeatures { get; set; }
    [Column("alert_quantity")]
    public int intAlert_quantity { get; set; }


    //foreign keys
    [Column("category_tuid")]
    public virtual Category objCategory { get; set; }
    public List<Quantity> lstQuantities { get; set; }
    public List<VendorItem> lstVendorItems { get; set; }
}
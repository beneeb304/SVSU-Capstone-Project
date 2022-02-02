using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class VendorItem
{
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("costInCents")]
    public int intCostInCents { get; set; }
    [Column("itemUrl")]
    public string strItemUrl { get; set; }
    [Column("commodity_tuid")]
    public virtual Commodity objCommodity { get; set; }
    [Column("vendor_tuid")]
    public virtual Vendor objVendor { get; set; }
}
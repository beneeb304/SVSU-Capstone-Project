using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class VendorItem
{
    [Key]
    public Guid uidTuid { get; set; }
    public int intCostInCents { get; set; }
    public virtual Commodity objCommodity { get; set; }
    public virtual Vendor objVendor { get; set; }
}
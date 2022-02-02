using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Quantity
{
    // Properties
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("quantity")]
    public int intQuantity { get; set; }

    // Foreign Keys
    [Column("nlevel_tuid")]
    public virtual NLevel objNLevel { get; set; }
    [Column("cabinet_tuid")]
    public virtual Cabinet objCabinet { get; set; }
    [Column("commodity_tuid")]
    public virtual Commodity objCommodity { get; set; }
}
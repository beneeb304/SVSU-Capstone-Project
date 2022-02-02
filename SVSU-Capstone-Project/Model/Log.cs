using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Log
{
    [Key,Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("action")]
    public string strAction { get; set; }
    [Column("timestamp")]
    public string strTimestamp { get; set; }
    [Column("notes")]
    public string strNotes { get; set; }
    [Column("quantityChange")]
    public int intQuantityChange { get; set; }

    [Column("user_tuid")]
    public virtual User objUser { get; set; }
    [Column("commodity_tuid")]
    public virtual Commodity lstCommodity { get; set; }
}
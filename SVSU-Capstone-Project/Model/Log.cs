using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Log
{
    [Key]
    public Guid uidTuid { get; set; }

    public string strAction { get; set; }
    public string strTimestamp { get; set; }
    public string strNotes { get; set; }
    public int intQuantityChange { get; set; }


    public virtual User objUser { get; set; }
    public virtual Commodity lstCommodity { get; set; }
}
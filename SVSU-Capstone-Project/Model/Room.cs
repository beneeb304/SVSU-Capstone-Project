using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

public class Room
{
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("name")]
    public string strName { get; set; }
    [Column("description")]
    public string strDescription { get; set; }

    public virtual List<Cabinet> lstCabinets { get; set; }
}
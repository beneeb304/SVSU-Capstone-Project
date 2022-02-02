using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cabinet
{
    [Key, Column("tuid")]
    public Guid uidTuid { get; set; }
    [Column("Name")]
    public string strName { get; set; }
    [Column("Description")]
    public string strDescription { get; set; }
    
    [Column("room_tuid")]
    public virtual Room objRoom { get; set; }
    public virtual List<Quantity> lstQuantities { get; set; }
}

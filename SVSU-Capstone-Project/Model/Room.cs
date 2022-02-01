using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

public class Room
{
    [Key]
    public Guid uidTuid { get; set; }
    public string strName { get; set; }
    public string strDescription { get; set; }

    public virtual List<Cabinet> lstCabinets { get; set; }
}
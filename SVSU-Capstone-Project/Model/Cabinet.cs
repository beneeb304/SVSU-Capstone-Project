using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cabinet
{
    [Key]
    public Guid tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public virtual Room room { get; set; }
    public virtual List<Quantity> quantities { get; set; }
}
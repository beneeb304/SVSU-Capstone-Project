using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

public class Room
{
    [Key]
    public Guid tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public virtual List<Cabinet> cabinets { get; set; }
}
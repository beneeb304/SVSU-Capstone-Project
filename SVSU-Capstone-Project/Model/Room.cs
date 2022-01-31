using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Room
{
    [Key]
    public string tuid { get; set; }
    public string room_name { get; set; }
    public string description { get; set; }

    public virtual List<Cabinet> cabinets { get; set; }
}
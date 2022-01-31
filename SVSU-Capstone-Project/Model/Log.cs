using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Log
{
    [Key]
    public string tuid { get; set; }

    public string action { get; set; }
    public string timestamp { get; set; }
    public string notes { get; set; }
    public int quantityChange { get; set; }


    public virtual User user { get; set; }
    public virtual Commodity commodity { get; set; }
}
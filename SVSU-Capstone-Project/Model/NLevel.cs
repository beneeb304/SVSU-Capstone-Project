using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class NLevel
{
    [Key]
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
   
    public virtual List<Quantity> quantities { get; set; }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public List<Commodity> commodities { get; set; }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Vendor
{
    [Key]
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    
    public virtual List<VendorItem> itemsSold { get; set; }
}
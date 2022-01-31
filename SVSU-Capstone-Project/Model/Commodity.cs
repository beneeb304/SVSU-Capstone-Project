using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Commodity
{
    //properties
    [Key]
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string features { get; set; }
    public int alert_quantity { get; set; }


    //foreign keys
    public virtual Category category { get; set; }
    public List<Quantity> quantities { get; set; }
    public List<VendorItem> vendorItems { get; set; }




}
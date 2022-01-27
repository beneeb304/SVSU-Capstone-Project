// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class Commodity
{
    //properties
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string features { get; set; }
    public int alert_quantity { get; set; }


    //foreign keys
    public string category_tuid { get; set; }
    public virtual Category category { get; set; }

    public List<Quantity> quantities { get; set; }
    public List<VendorItem> vendorItems { get; set; }




}
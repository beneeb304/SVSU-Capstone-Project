// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

public class VendorItem
{
    public string tuid { get; set; }
    public string commodity_tuid { get; set; }
    public virtual Commodity commodity { get; set; }
    public string vendor_tuid { get; set; }
    public virtual Vendor vendor { get; set; }
}
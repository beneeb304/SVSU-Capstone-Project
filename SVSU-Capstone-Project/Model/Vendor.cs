// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class Vendor
{
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    
    public virtual List<Commodity> commodities { get; set; }
}
// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class Category
{
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public List<Commodity> commodities { get; set; }
}
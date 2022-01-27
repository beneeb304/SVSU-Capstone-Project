// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class NLevel
{
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }
   
    public virtual List<Quantity> quantities { get; set; }
}
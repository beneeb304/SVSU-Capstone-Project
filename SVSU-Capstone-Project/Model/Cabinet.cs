// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class Cabinet
{
    public string tuid { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public string room_tuid { get; set; }
    public virtual Room room { get; set; }

    public virtual List<Quantity> quantities { get; set; }
}
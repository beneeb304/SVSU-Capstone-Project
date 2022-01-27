// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Collections.Generic;

public class Room
{
    public string tuid { get; set; }
    public string room_name { get; set; }
    public string description { get; set; }

    public virtual List<Cabinet> cabinets { get; set; }
}
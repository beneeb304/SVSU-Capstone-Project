// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

public class Log
{
    public string tuid { get; set; }

    public string action { get; set; }
    public string timestamp { get; set; }
    public string notes { get; set; }
    public int quantityChange { get; set; }


    public string user_tuid { get; set; }
    public virtual User user { get; set; }

    public string commodity_tuid { get; set; }
    public virtual Commodity commodity { get; set; }
}
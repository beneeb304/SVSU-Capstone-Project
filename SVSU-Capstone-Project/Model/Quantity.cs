// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

public class Quantity
{
    // Properties
    public string tuid { get; set; }
    public int quantity { get; set; }

    // Foreign Keys
    public string nlevel_tuid { get; set; }
    public virtual NLevel nlevel { get; set; }
    public string cabinet_tuid { get; set; }
    public virtual Cabinet cabinet { get; set; }
    public string commodity_tuid { get; set; }
    public virtual Commodity commodity { get; set; }
}
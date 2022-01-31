using System.ComponentModel.DataAnnotations;

public class Quantity
{
    // Properties
    [Key]
    public string tuid { get; set; }
    public int quantity { get; set; }

    // Foreign Keys
    public virtual NLevel nlevel { get; set; }
    public virtual Cabinet cabinet { get; set; }
    public virtual Commodity commodity { get; set; }
}
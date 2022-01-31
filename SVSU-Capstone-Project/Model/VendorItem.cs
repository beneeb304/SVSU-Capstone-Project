using System.ComponentModel.DataAnnotations;

public class VendorItem
{
    [Key]
    public string tuid { get; set; }
    public int costInCents { get; set; }
    public virtual Commodity commodity { get; set; }
    public virtual Vendor vendor { get; set; }
}
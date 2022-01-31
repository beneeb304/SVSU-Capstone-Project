// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Data.Entity;
using System.Linq;

public class InvDb : DbContext
{
    public InvDb() : base("name=InvDb")
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Cabinet> Cabinets { get; set; }
    public DbSet<NLevel> NLevels { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Commodity> Commodites { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Quantity> Quantities { get; set; }
    public DbSet<VendorItem> VendorItems { get; set; }
}
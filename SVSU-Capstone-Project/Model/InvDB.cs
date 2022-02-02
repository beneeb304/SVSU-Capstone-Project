// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------

using System.Data.Entity;
using System.Linq;

public class InvDb : DbContext
{
    public InvDb() : base("strName=InvDb")
    {

    }
    
    public DbSet<Category> dsCategories { get; set; }
    public DbSet<Room> dsRooms { get; set; }
    public DbSet<Cabinet> dsCabinets { get; set; }
    public DbSet<NLevel> dsNLevels { get; set; }
    public DbSet<Vendor> dsVendors { get; set; }
    public DbSet<Commodity> dsCommodites { get; set; }
    public DbSet<Log> dsLogs { get; set; }
    public DbSet<User> dsUsers { get; set; }
    public DbSet<Quantity> dsQuantities { get; set; }
    public DbSet<VendorItem> dsVendorItems { get; set; }
}
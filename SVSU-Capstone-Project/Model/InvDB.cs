// --------------------------------------------------------------------
// !!! Define Schema as seperate class files under the Model folder !!!
// --------------------------------------------------------------------
namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class InvDb : DbContext
    {
        public InvDb() : base("name=InvDb")
        {

        }

        public DbSet<Category> dsCategories { get; set; }
        public DbSet<Room> dsRooms { get; set; }
        public DbSet<Cabinet> dsCabinets { get; set; }
        public DbSet<NLevel> dsNLevels { get; set; }
        public DbSet<Vendor> dsVendors { get; set; }
        public DbSet<Commodity> dsCommodities { get; set; }
        public DbSet<Log> dsLogs { get; set; }
        public DbSet<User> dsUsers { get; set; }
        public DbSet<Quantity> dsQuantities { get; set; }
        public DbSet<VendorItem> dsVendorItems { get; set; }
    }
    public class ContextEntity
    {
        [Key, Column("tuid")]
        public Guid uidTuid { get; set; }

        public override bool Equals( object obj )
        {
            return obj is ContextEntity entity &&
                   uidTuid.CompareTo(entity.uidTuid) == 0;
        }

        // override equal operator
        public static bool operator == ( ContextEntity left, ContextEntity right )
        {
            if (left is null && right is null)
                return true;
            else if (left is null || right is null)
                return false;
            else
                return left.Equals(right);
        }
        public static bool operator != ( ContextEntity left, ContextEntity right )
        {
            if (left is null && right is null)
                return false;
            else if (left is null || right is null)
                return true;
            else
                return !(left.Equals(right));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public enum ItemType
    {
        Consumable,
        Equipment,
        Simulator
    }

}

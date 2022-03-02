namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Storage")]
    public class Storage : ContextEntity
    {
        [Column("quantity")]
        public int intQuantity { get; set; } = 0;

        // Foreign Keys
        public virtual NLevel objNLevel { get; set; }
        public virtual Cabinet objCabinet { get; set; }
        public virtual Commodity objCommodity { get; set; }
    }
}

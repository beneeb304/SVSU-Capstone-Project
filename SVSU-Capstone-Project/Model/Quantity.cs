namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Quantity : ContextEntity
    {
        [Column("quantity")]
        public int intQuantity { get; set; }

        // Foreign Keys
        public virtual NLevel objNLevel { get; set; }
        public virtual Cabinet objCabinet { get; set; }
        public virtual Commodity objCommodity { get; set; }
    }
}

namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class VendorItem: ContextEntity
    {
        [Column("costInCents")]
        public int intCostInCents { get; set; }
        [Column("itemUrl")]
        public string strItemUrl { get; set; }

        public virtual Commodity objCommodity { get; set; }
        public virtual Vendor objVendor { get; set; }
    }
}

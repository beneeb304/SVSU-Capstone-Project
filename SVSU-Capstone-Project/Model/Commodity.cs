namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Commodity : ContextEntity
    {
        [Column("name"), Index(IsUnique = true), MaxLength(255)]
        public string strName { get; set; }
        [Column("description")]
        public string strDescription { get; set; }
        [Column("features")]
        public string strFeatures { get; set; }
        [Column("alert_quantity")]
        public int intAlert_quantity { get; set; }
        [Column("commodityType")]
        public ItemType enuCommodityType { get; set; }        
        [Column("costInCents")]
        public int intCostInCents { get; set; }
        [Column("itemUrl")]
        public string strItemUrl { get; set; }


        //foreign keys       
        public virtual Category objCategory { get; set; }
        public virtual List<Storage> lstStorage { get; set; }
        public virtual Vendor objVendor { get; set; }
        public virtual List<CheckedItem> lstCheckedItems { get; set; }

        // override tostring with strName
        public override string ToString()
        {
            return strName;
        }
    }
}

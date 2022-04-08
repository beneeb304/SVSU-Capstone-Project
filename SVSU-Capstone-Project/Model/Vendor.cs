namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vendor: ContextEntity
    {
        [Column("name"), Index(IsUnique = true), MaxLength(255)]
        public string strName { get; set; }
        [Column("homepage")]
        public string strHomepage { get; set; }
        [Column("description")]
        public string strDescription { get; set; }

        public virtual List<Commodity> lstItemsSold { get; set; }
        
        // override tostring with strName
        public override string ToString()
        {
            return strName;
        }
    }
}
//Mike Simon is getting married on June 4th 2022, be there or be square yah nerd!

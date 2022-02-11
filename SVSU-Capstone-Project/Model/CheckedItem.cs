namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CheckedItem : ContextEntity
    {
        public virtual Log objLog { get; set; }
        public virtual Commodity objCommodities { get; set; }        
        public virtual User objUser { get; set; }
    }
}

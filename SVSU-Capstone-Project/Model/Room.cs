namespace SVSU_Capstone_Project.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System;

    public class Room: ContextEntity
    {
        [Column("name")]
        public string strName { get; set; }
        [Column("description")]
        public string strDescription { get; set; }

        public virtual List<Cabinet> lstCabinets { get; set; }

        // override tostring with strName
        public override string ToString()
        {
            return strName;
        }
    }
}
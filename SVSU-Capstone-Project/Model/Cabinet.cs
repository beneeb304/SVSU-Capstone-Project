﻿namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    
    public class Cabinet : ContextEntity
    {
        [Column("name"), MaxLength(255)]
        public string strName { get; set; }
        [Column("description")]
        public string strDescription { get; set; }

        public virtual Room objRoom { get; set; }
        public virtual List<Storage> lstStorage { get; set; }

        // override tostring with strName
        public override string ToString()
        {
            return strName;
        }
    }
}

namespace SVSU_Capstone_Project.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SimulatorUse : ContextEntity
    {
        [Column("hoursUsed")]
        public int intHoursUsed { get; set; } = 0;

        [Column("timesUsed")]
        public int intTimesUsed { get; set; } = 0;

        //Foreign Key
        public virtual Commodity objCommodity { get; set; }

    }
}

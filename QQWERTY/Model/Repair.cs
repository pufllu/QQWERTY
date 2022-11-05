using System;
using System.Collections.Generic;


namespace QQWERTY
{
    public partial class Repair
    {
        public int id { get; set; }
        public int device { get; set; }
        public string comment { get; set; }
        public int status { get; set; }
        public Nullable<decimal> cost { get; set; }

        public virtual ICollection<PartsToRepair> PartsToRepair { get; set; }
        public virtual Status Status1 { get; set; }
        public virtual Device Device1 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QQWERTY
{
    public partial class Worker
    {
        [Key]
        public int tabNum { get; set; }
        public string FIO { get; set; }
        public int position { get; set; }
        public decimal oklad { get; set; }
        public Nullable<decimal> percentToRepair { get; set; }
        public string password { get; set; }
        public string TitleStatus { get => TitleStatus; }

        public virtual ICollection<Device> Device { get; set; }
        public virtual Position Position1 { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QQWERTY
{
    public partial class Client
    {
        [Key]
        public int Num { get; set; }
        public string name { get; set; }
        public string serialPass { get; set; }
        public string numberPas { get; set; }
        public string phone { get; set; }

        public virtual ICollection<Device> Device { get; set; }
    }
}

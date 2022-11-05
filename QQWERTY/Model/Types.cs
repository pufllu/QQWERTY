using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Types
    {
        public int id { get; set; }
        public string title { get; set; }
        public virtual ICollection<Device> Device { get; set; }
    }
}

using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Type
    {
        public int id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Device> Device { get; set; }
    }
}

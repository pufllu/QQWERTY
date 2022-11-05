using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Status
    {
        public int id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Repair> Repair { get; set; }
    }
}

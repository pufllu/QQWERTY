using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Position
    {
        public int id { get; set; }
        public string title { get; set; }
        public virtual ICollection<Worker> Worker { get; set; }
    }
}

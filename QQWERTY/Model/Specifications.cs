using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Specifications
    {
        public int id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<SpecificationsOfPart> SpecificationsOfPart { get; set; }
    }
}

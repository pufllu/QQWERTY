using System.Collections.Generic;

namespace QQWERTY
{
    public partial class DevicePart
    {
        public int id { get; set; }
        public string title { get; set; }
        public int count { get; set; }
        public decimal cost { get; set; }
        public byte[] image { get; set; }

        public virtual ICollection<PartsToRepair> PartsToRepair { get; set; }
        public virtual ICollection<SpecificationsOfPart> SpecificationsOfPart { get; set; }
    }
}

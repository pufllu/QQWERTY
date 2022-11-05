using System.ComponentModel.DataAnnotations;

namespace QQWERTY
{
    public partial class PartsToRepair
    {
        [Key]
        public int idRepair { get; set; }
        public int idpart { get; set; }
        public int count { get; set; }

        public virtual DevicePart DevicePart { get; set; }
        public virtual Repair Repair { get; set; }
    }
}

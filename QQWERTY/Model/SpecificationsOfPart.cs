using System.ComponentModel.DataAnnotations;

namespace QQWERTY
{
    public partial class SpecificationsOfPart
    {
        [Key]
        public int idScpecification { get; set; }
        public int idPart { get; set; }
        public decimal value { get; set; }

        public virtual DevicePart DevicePart { get; set; }
        public virtual Specifications Specifications { get; set; }
    }
}

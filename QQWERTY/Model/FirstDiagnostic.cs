using System.ComponentModel.DataAnnotations;

namespace QQWERTY
{
    public partial class FirstDiagnostic
    {
        [Key]
        public int idDiagnostic { get; set; }
        public int device { get; set; }
        public string description { get; set; }

        public virtual Device Device1 { get; set; }
    }
}

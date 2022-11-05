using System;
using System.Collections.Generic;

namespace QQWERTY
{
    public partial class Device
    {
        public int id { get; set; }
        public int type { get; set; }
        public string model { get; set; }
        public string damage { get; set; }
        public string complaint { get; set; }
        public Nullable<int> master { get; set; }
        public int client { get; set; }

        public virtual Client Client1 { get; set; }
        public virtual Type Type1 { get; set; }
        public virtual Types Types { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<FirstDiagnostic> FirstDiagnostic { get; set; }
        public virtual ICollection<Repair> Repair { get; set; }
    }
}

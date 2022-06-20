using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class training
    {
        public int IdTra { get; set; }
        public string Name { get; set; } = null!;
        public string TrainingPlace { get; set; } = null!;

        public virtual PersonList PersonList { get; set; } = null!;
    }
}

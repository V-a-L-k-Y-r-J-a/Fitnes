using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class Coach
    {
        public int IdCo { get; set; }
        public string FristNam { get; set; } = null!;
        public string LastNam { get; set; } = null!;
        public string Patromym { get; set; } = null!;
        public string Phones { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual Lesson Lesson { get; set; } = null!;
    }
}

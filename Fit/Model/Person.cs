using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class Person
    {
        public int IdPer { get; set; }
        public string FristNames { get; set; } = null!;
        public string LastNames { get; set; } = null!;
        public string Patronymics { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string MedicalCart { get; set; } = null!;
        public string TypeTraining { get; set; } = null!;

        public virtual Lesson Lesson { get; set; } = null!;
    }
}

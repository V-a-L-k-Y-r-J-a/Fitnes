using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class PersonList
    {
        public int IdList { get; set; }
        public int IdUser { get; set; }
        public int IdLessons { get; set; }
        public int IdTra { get; set; }

        public virtual Lesson IdLessonsNavigation { get; set; } = null!;
        public virtual User IdList1 { get; set; } = null!;
        public virtual training IdListNavigation { get; set; } = null!;
    }
}

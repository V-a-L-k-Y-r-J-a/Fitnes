using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class Lesson
    {
        public Lesson()
        {
            PersonLists = new HashSet<PersonList>();
        }

        public int IdLessins { get; set; }
        public TimeSpan TrainingTime { get; set; }
        public string TrainingType { get; set; } = null!;
        public DateTime TrainingDate { get; set; }
        public int IdCo { get; set; }
        public int IdPer { get; set; }

        public virtual Person IdLessins1 { get; set; } = null!;
        public virtual Coach IdLessinsNavigation { get; set; } = null!;
        public virtual ICollection<PersonList> PersonLists { get; set; }

       
    }
}

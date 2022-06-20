using System;
using System.Collections.Generic;

namespace Fit.Model
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string FristName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string Post { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Pass { get; set; } = null!;

        public virtual PersonList PersonList { get; set; } = null!;
    }
}

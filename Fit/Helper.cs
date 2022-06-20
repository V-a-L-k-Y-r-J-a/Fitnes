using Fit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit
{
    internal class Helper
    {
        public static fitnessContext db = new fitnessContext();
        public static User userSession;
        public static Person peopleSession;
        public static Coach coachesSession;
        internal static Coach? Coach;
        internal static training? training;
    }
}

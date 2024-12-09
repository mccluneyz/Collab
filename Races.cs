using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_mccluneyz
{
    public class Race
    {
        private string email;
        private string raceDate;
        private string track;
        private double timeElapsed;
        private int kartID;
        private bool kartReturned;


        public Race(string email, string raceDate, string track, double timeElapsed, int kartID, bool kartReturned)
        {
            this.email = email;
            this.raceDate = raceDate;
            this.track = track;
            this.timeElapsed = timeElapsed;
            this.kartID = kartID;
            this.kartReturned = kartReturned;
        }
    }

    
}
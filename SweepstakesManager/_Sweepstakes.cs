using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class _Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public string sweepstakesName;

        public _Sweepstakes()
        {
            
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public string pickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
        
    }
}

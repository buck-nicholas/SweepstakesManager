using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory
    {
        public ISweepstakesManager DeterminManager(string managerType)
        {
            switch (managerType)
            {
                case "1":
                    return new SweepstakesQueueManager();
                case "2":
                    return new SweepstakesStackManager();
                default:
                    return DeterminManager(managerType);
            }
        }
    }
}

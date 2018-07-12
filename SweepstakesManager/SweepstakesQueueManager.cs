using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<_Sweepstakes> sweepstakesQueue = new Queue<_Sweepstakes>();
        public void InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public _Sweepstakes GetSweepstakes()
        {
            _Sweepstakes sweepstakesQueueStart = sweepstakesQueue.Dequeue();
            return sweepstakesQueueStart;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager :ISweepstakesManager
    {
        Stack<_Sweepstakes> sweepstakesStack = new Stack<_Sweepstakes>(); 
        public void InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
        public _Sweepstakes GetSweepstakes()
        {
            _Sweepstakes sweepstakesFromStack = sweepstakesStack.Pop();
            return sweepstakesFromStack;
        }
    }
}

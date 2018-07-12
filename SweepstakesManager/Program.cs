using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Used to loop back to sweepstakesFactory to select another manager type if needed.
            {
                SweepstakesFactory sweepstakesFactory = new SweepstakesFactory();
                MarketingFirm newFirm = new MarketingFirm(sweepstakesFactory.DetermineManager(UserInterface.GetManagerType()));
                newFirm.DetermineMarketFirmAction();
            }
        }
    }
}

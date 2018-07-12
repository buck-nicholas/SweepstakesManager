﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }
        public _Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }
        public void InsertSweepstakes()
        {
            sweepstakesManager.InsertSweepstakes(UserInterface.CreateSweepstake());
        }
    }
}

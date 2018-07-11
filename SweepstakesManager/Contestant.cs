using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }
    }
}

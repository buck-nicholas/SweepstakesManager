using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetContestantFirstName()
        {
            string userInput = GetUserInput("Please enter your first name: ");
            return userInput;
        }
        public static string GetContestantLastName()
        {
            string userInput = GetUserInput("Please enter your last name: ");
            return userInput;
        }
        public static string GetContestantEmailAddress()
        {
            string userInput = GetUserInput("Please enter your email address: ");
            return userInput;
        }
        public static Guid SetRegistrationNumber()
        {
            Guid newGuid;
            newGuid = Guid.NewGuid();
            return newGuid;
        }
        public static string GetManagerType()
        {
            string managerType = GetUserInput("Select Required Manager:\n[1] Stack Manager\n[2] Queue Manager");
            return managerType;
        }
        public static _Sweepstakes CreateSweepstake()
        {
            _Sweepstakes newSweepstake = new _Sweepstakes();
            return newSweepstake;
        }
    }
}

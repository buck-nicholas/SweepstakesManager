using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        private List<string> contestantPrompts = new List<string>();
        public UserInterface()
        {
            InsertContestantPrompts();
        }
        public string GetUserInput(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public void InsertContestantPrompts()
        {
            contestantPrompts.Add("Please enter your first name: ");
            contestantPrompts.Add("Please enter your last name: ");
            contestantPrompts.Add("Please enter your email address: ");
        }
        public void GetContestantInformation()
        {
            string firstName = GetUserInput(contestantPrompts[0]);
            string lastName = GetUserInput(contestantPrompts[1]);
            string emailAddress = GetUserInput(contestantPrompts[2]);           
        }

        public void SetRegistrationNumber()
        {
            // if list of contestants is empty => start at 1
            // if list of contestants is not empty => get last contestants registration number, add one
            // int contestant.registrationNumber = previous contestants number plus 1
        }
    }
}

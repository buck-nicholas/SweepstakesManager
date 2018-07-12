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
        public static void InsertContestantPrompts()
        {
            List<string> contestantPrompts = new List<string>();
            contestantPrompts.Add("Please enter your first name: ");
            contestantPrompts.Add("Please enter your last name: ");
            contestantPrompts.Add("Please enter your email address: ");
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
    }
}

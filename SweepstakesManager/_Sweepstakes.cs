using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class _Sweepstakes
    {
        Dictionary<Guid, Contestant> contestants = new Dictionary<Guid, Contestant>();
        public string sweepstakesName;
        private readonly static Random randomNumber = new Random();
        Contestant contestant;
        public _Sweepstakes()
        {
            sweepstakesName = UserInterface.GetUserInput("Enter Sweepstakes Name: ");
        }
        public void CreateNewContestant()
        {
            Contestant newContestant = new Contestant();
            RegisterContestant(newContestant);
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            contestants.Count();
            Contestant winner = contestants.ElementAt(randomNumber.Next(contestants.Count - 1)).Value;
            string sweepstakesWinner = winner.firstName + " " + winner.lastName;
            return sweepstakesWinner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Information for contestant registration number: {0}\nName: {1} {2}\nEmail Address: {3}", contestant.registrationNumber, contestant.firstName, contestant.lastName, contestant.emailAddress);
        }
        public void SetSweepStakesName()
        {
            Console.Write("Sweepstakes Name: ");
            Console.ReadLine();
        }
    }
}

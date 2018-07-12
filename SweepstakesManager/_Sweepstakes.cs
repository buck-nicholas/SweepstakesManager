using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class _Sweepstakes
    {
        Dictionary<Guid, Contestant> contestants = new Dictionary<Guid, Contestant>();
        public string sweepstakesName;
        private readonly static Random randomNumber = new Random();
        Contestant contestant;
        public _Sweepstakes()
        {
            SetSweepStakesName();
            DetermineWantedAction();
        }
        public void DetermineWantedAction()
        {
            while (true)
            {
                switch (UserInterface.DetermineSweepstakeAction())
                {
                    case "1":
                        AddContestant();
                        break;
                    case "2":
                        DisplayContestants();
                        break;
                    case "3":
                        PickWinner();
                        break;
                    case "4":
                        return;
                    default:
                        return;
                }
            }
        }
        public void SetSweepstakesName()
        {
            if(sweepstakesName == null)
            {
                sweepstakesName = UserInterface.GetUserInput("Enter Sweepstakes Name: ");
            }
        }
        public void AddContestant()
        {
            bool isDone = false;
            while (!isDone)
            {
                CreateNewContestant();
                RegisterContestant(contestant);
                isDone = isDoneAddingContestants();
            }
        }
        public bool isDoneAddingContestants()
        {
            if (UserInterface.IsDoneAddingContestants().ToLower() == "no")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CreateNewContestant()
        {          
            contestant = new Contestant();
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
        public void DisplayContestants()
        {
            foreach(KeyValuePair<Guid, Contestant> keyvaluepair in contestants)
            {
                Console.WriteLine(keyvaluepair.Value.firstName + " " + keyvaluepair.Value.lastName + " Registration Number: " + keyvaluepair.Value.registrationNumber);
            }
        }
    }
}

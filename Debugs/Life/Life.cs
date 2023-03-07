using System;
using Human;

namespace Life
{
    class Beginning
    {
        private string job = "Unemployed";

        public Manifest manifest = new Manifest("Manifest");

        public string Name
        {
            get { return manifest.Name; }
            set { manifest.Name = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public Beginning(string vName)
        {
            manifest.Name = vName;
        }

        static void Main(string[] args)
        {
            Console.Write("Hello, user! Enter your name here to start a new beginning: ");
            Life.Beginning myPerson = new Beginning(Console.ReadLine() ?? "Unknown");
            Console.Write("\nWelcome to the system, " + myPerson.Name + "! You are 18 years old, living in an apartment, and looking for a job.\nHere are the current jobs that are hiring:\n\n[1]: Chef : Salary = 40k/Year\n[2]: Teacher : Salary = 80k/Year\n\nChose a job you would like to apply to here: ");

            int jobChoice = Convert.ToInt32(Console.ReadLine()) - 1;
            string[] jobs = {"Chef", "Teacher"};

            myPerson.Job = (jobChoice < jobs.Length) ? jobs[jobChoice] : "Unemployed";
            Console.WriteLine();

            switch (myPerson.Job)
            {
                case "Unemployed":
                    Console.WriteLine("Sadly, there were no jobs found in the range you selected. You remain Unemployed.");
                    break;

                case "Chef":
                    Console.WriteLine("You were interviewed for a position at a nearby restaurant.\nLuckily, you brought your cooking skills with you- you passed.\n\nYou have been hired as a Chef.");
                    break;

                case "Teacher":
                    Console.WriteLine("You went to college for four years to obtain your teaching credentials. You now find a school to apply for a job at.\nYou have been interviewed and- you passed.\n\nYou have been hired as a Teacher.");
                    break;

                default:
                    break;
            }
        }
    }
}

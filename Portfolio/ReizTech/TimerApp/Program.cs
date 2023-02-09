using System.Transactions;
using System;
using System.Collections.Generic;

namespace TimerApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StartAngleCalculator();
        }

        public static void StartAngleCalculator()
        {
            //calculations with current time 

            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            Console.Write($"now is hour: {hour} minutes: {minute}");
            TimerAngleCalculations(hour, minute);

            TimeInput();
        }

        public static void TimeInput()
        {
            bool success1 = false;
            bool success2 = false;
            //custom time input with validation for numbers

            do
            {
                Console.Write("Enter hour (0-12): ");
                string sk1temp = Console.ReadLine();
                success1 = int.TryParse(sk1temp, out int hour);
                if (!success1) Console.WriteLine("not a number ");

                Console.Write("Enter minute (0-59): ");
                string sk2temp = Console.ReadLine();
                success2 = int.TryParse(sk2temp, out int minute);
                if (!success2) Console.WriteLine("not a number  ");

                if(success1 == true && success2 == true)
                {
                    TimerAngleCalculations(hour, minute);
                }
              

            } while (success1 == false || success2 == false);

            
        }

        public static void TimerAngleCalculations(double hour, double minute)
        {
            //calculations
            double hourAngle = (hour % 12 + minute / 60.0) * 30;
            double minuteAngle = minute * 6;
            double angle = Math.Abs(hourAngle - minuteAngle);
            DataShow(angle);
        }

        public static void DataShow(double angle)
        {
            Console.WriteLine();
            Console.WriteLine("The smaller angle between the hour and minute hands is: " + Math.Min(angle, 360 - angle) + " degrees.");
            Console.WriteLine("The bigger angle between the hour and minute hands is: " + Math.Max(angle, 360 - angle) + " degrees.");

            TimeMeniu();
        }

        public static void TimeMeniu()
        {
            Console.WriteLine("1. Input custom time values \n2. Second Task. \n3. Exit. ");
            string mainMeniu = Convert.ToString(Console.ReadLine());
            switch (mainMeniu)
            {
                case "1":
                    TimeInput();
                    break;
                case "2":
                    SecondTask();
                    break;
                case "3":
                    Console.WriteLine("Exit");
                    System.Environment.Exit(-1);
                    break;

            }
        }

        public static void SecondTask()
        {
            Console.Write("Enter the MaxLevel of branches to be generated: ");
            int maxLevel = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int numberOfBranches = random.Next(0, maxLevel);

            Branch root = new Branch();
            GenerateBranches(root, numberOfBranches);

            int depth = CalculateDepth(root, 0);
            Console.WriteLine("Depth of the hierarchical structure: " + depth);
            Console.ReadLine();
            System.Environment.Exit(-1);
        }



        public static void GenerateBranches(Branch branch, int numberOfBranches)
        {
            if (numberOfBranches == 0)
                return;

            branch.Branches.Add(new Branch());
            GenerateBranches(branch.Branches[0], numberOfBranches - 1);
        }

        public static int CalculateDepth(Branch branch, int depth)
        {
            if (branch.Branches.Count == 0)
                return depth;

            int maxDepth = 0;
            foreach (Branch childBranch in branch.Branches)
            {
                int childDepth = CalculateDepth(childBranch, depth + 1);
                if (childDepth > maxDepth)
                {
                    maxDepth = childDepth;
                }
            }

            return maxDepth;
        }








    }

  

}

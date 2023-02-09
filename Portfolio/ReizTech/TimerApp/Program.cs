using System.Transactions;

namespace TimerApp
{
    public class Program
    {
        public static void Main(string[] args)
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
            Console.WriteLine("1. Input custom time values \n2. Exit. ");
            string mainMeniu = Convert.ToString(Console.ReadLine());
            switch (mainMeniu)
            {
                case "1":
                    TimeInput();
                    break;

                case "2":
                    Console.WriteLine("Exit");
                    System.Environment.Exit(-1);
                    break;

            }
        }
    }
}

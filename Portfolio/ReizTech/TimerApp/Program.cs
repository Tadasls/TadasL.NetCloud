namespace TimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter hour (0-12): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minute (0-59): ");
            int minute = Convert.ToInt32(Console.ReadLine());

            double hourAngle = (hour % 12 + minute / 60.0) * 30;
            double minuteAngle = minute * 6;
            double angle = Math.Abs(hourAngle - minuteAngle);

            Console.WriteLine("The smaller angle between the hour and minute hands is: " + Math.Min(angle, 360 - angle) + " degrees.");
            Console.WriteLine("The bigger angle between the hour and minute hands is: " + Math.Max(angle, 360 - angle) + " degrees.");
            Console.ReadLine();

        }
    }
}
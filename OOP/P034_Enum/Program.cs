namespace P034_Enum
{
    public class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Hello, Enums!");

            int sunday = 1;
            int monday = 2;
            int tuesday = 3;
            int wednesday = 4;
            int thursday = 5;
            int friday = 6;
            int saturday = 7;

            int dayOfWeek = friday;
            //--------------------------------

            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            Console.WriteLine($"today is {today}");
            int todayInt = (int)EDaysOfWeek.Tuesday;
            Console.WriteLine($"today is {todayInt}");


            int todayNumber = 2;
            EDaysOfWeek today1 = (EDaysOfWeek)todayNumber;
            Console.WriteLine($"today1 is {today1}");

            EDaysOfWeek today2 = (EDaysOfWeek)2;
            Console.WriteLine($"today2 - {today2}");

            //---------------------

            int today3 = DayOfWeekEnum.Tuesday;

            CustomsEnum today4 = DayOfWeekCustomEnum.Tuesday;

        }
    }

    public enum EDaysOfWeek { Sunday, Monday, Tuesday, Wenesday, Thursday, Friday, Saturday }
    public enum EDaysOfWeek1 {
        Sunday = 5,
        Monday = 6,
        Tuesday = 7,
        Wenesday = 8,
        Thursday = 9,
        Friday = 10,
        Saturday = 11
    }

    public class CustomsEnum
    {
        public CustomsEnum(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }


    public class DayOfWeekCustomEnum
    {
        public static CustomsEnum Sunday => new CustomsEnum(1, nameof(Sunday));
        public static CustomsEnum Monday => new CustomsEnum(2, nameof(Monday));
        public static CustomsEnum Tuesday => new CustomsEnum(3, nameof(Tuesday));
        public static CustomsEnum Wenesday => new CustomsEnum(4, nameof(Wenesday));
        public static CustomsEnum Thursday => new CustomsEnum(5, nameof(Thursday));
        public static CustomsEnum Friday => new CustomsEnum(6, nameof(Friday));
        public static CustomsEnum Saturday => new CustomsEnum(6, nameof(Saturday));
     
               
            
        

    }

}
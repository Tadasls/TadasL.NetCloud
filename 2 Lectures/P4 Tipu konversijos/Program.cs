namespace P4_Tipu_konversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // dirbame su Implici5t casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; //tipo konversija daroma automatiskai

            var castintasLong2 = (long)skaiciusInt;
            
            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;

            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLong2;
            double skaiciusDouble3 = skaiciusFloat2;
            decimal  skaiciusDecimal = skaiciusByte;
            //byte short int float double decimal



            //explicit casting 
            int castintasInt = (int)skaiciusLong;


            //decimal -> double - float long int char

            float fl = 5.6f;
            int castintasInt1 = (int)fl;

          Console.WriteLine("   i={0} ", castintasInt1);


            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;

            Console.WriteLine($" castintasint2={castintasInt2} ");

            long castintasLong3 = skaiciusRaide;

            //char ushort - int - uint 

            string a = "a";

           // negalima teksto castinti i integerius//  int castintasInt3 = (int)a;
           Console.WriteLine("   i={0} ", skaiciusRaide);




            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            
            Console.WriteLine($"  castintasInt4= {castintasInt4}"); 

            long SkaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)SkaiciusLongDarDidesnis;
            Console.WriteLine($"  castintas Int5= {castintasInt5}");      

            // castinime is didesnio skaiciaus i mazesni programa padaro baisiausia dalyka, veikia nekorektiskai.






        }
    }
}
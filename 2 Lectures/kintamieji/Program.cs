namespace kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, skaiciai!");
            //skaiciu kintamieji
            //sveiku skaiciu kintamieji
            /*
            byte mazasSkaicius = 200; //255
            short trumpasSKaicius = 2; //32767 ir neigiami 16 bit
            int skaicius = 2; //2.147.483.647 ir neigiami
            int masimalusIntSkaitmuo = int.MaxValue;
            int mainimalusIntSkaitmuo = int.MinValue;
            Console.WriteLine("lauke zaibuoja  max " +  masimalusIntSkaitmuo);
            Console.WriteLine("lauke zaibuoja  min " + mainimalusIntSkaitmuo);

            long ilgasSkaicius = 2; // 64 bit


            Console.WreiteLine("Floating point types");
            float maziausias Trupmeninis = 8.5f;
            var trupmeninisVar = 8.5;
            decimal didziausiasTrupmenisnis = 8.5m;





            var studentuSkaicius = 19
            var siandienosData = new DateTime(2022, 06, 08)

            Console.WriteLine("kursiPavadinimas -{0}\nkuroPavadinimas-{1}\n ");


                       // Console.WriteLine($"mokyklosPavadinimas - {mokyklos pavadinimas} \n) +" +
             //   $"kursoPavadinimas - {kursoPavadinimas};
             */




            Console.WriteLine("-------------------------");


            var kursoPradziosData = new DateTime(2022, 05, 30);
            var kursoPabaigosData = new DateTime(2022, 12, 01);
            TimeSpan kursoTrukme = /*siandienosData - */ kursoPradziosData; 
          
            Console.WriteLine("{0}\n{1}\n{2}", 
                kursoPradziosData.ToShortDateString(),
                kursoPabaigosData.ToShortDateString(), 
                kursoTrukme.Days);



           var tekstinisTipoKintamas = "Tadas";
           var  skaitinisTipas = 5;
           var  loginioTipo = true;

            Console.WriteLine($"{tekstinisTipoKintamas} {skaitinisTipas} {loginioTipo}");

            





        }
    }
}
namespace kintamieji_uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {



            {
                /*UŽDUOTIS
           ************************************************************************************************************************
          PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
           • MOKYKLOS PAVADINIMĄ
           • KURSO PAVADINIMĄ
           • STUDENTŲ SKAIČIŲ
           • ŠIANDIENOS DATĄ
           • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ

           */
                
                var mokyklosPavadinimas = "CodeAcademija";
                var kursoPavadinimas = "dotNetas";
                var studentuSkaicius = 19;
                var siandienosData = DateTime.Now;

                Console.WriteLine(" visa informacija: Mokykla {0} \n mokinames{1} \n studentu {2} \n  data {3}", mokyklosPavadinimas, kursoPavadinimas, studentuSkaicius, siandienosData);
                Console.WriteLine($" visa informacija: Mokykla {mokyklosPavadinimas}, \n mokslai {kursoPavadinimas},\n studentai {studentuSkaicius},\n data {siandienosData}, ");
                               
                Console.WriteLine("Tadas");

                Console.WriteLine( "{0}",siandienosData);
                Console.WriteLine( "{0}",siandienosData.ToShortDateString());
                Console.WriteLine($" {siandienosData}");


                

                /*
                var mokyklosPavadinimas = "CodeAcademy";
                var kursoPavadinimas = "CA.NET2";
                var studentuSkaicius = 19;
                var siandienosData = new DateTime(2022, 06, 08);
                Console.WriteLine("kursoPavadinimas-{0}\nkursoPavadinimas-{1}\nstudentuSkaicius-{2}\nsiandienosData-{3}",
                   mokyklosPavadinimas,
                   kursoPavadinimas,
                   studentuSkaicius,
                   siandienosData.ToShortDateString());
                Console.WriteLine($"mokyklosPavadinimas - {mokyklosPavadinimas} \n " +
                    $"kursoPavadinimas - {kursoPavadinimas} \n " +
                    $"studentuSkaicius - {studentuSkaicius} \n " +
                    $"siandienosData - {siandienosData}");
                */



                /*UŽDUOTIS
                   ************************************************************************************************************************
                  PAPILDYTI PROGRAMĄ IR PRIDĖTI:
                   • KURSO PRADŽIOS DATĄ
                   • KURSO PABAIGOS DATĄ
                   • Sužinoti skirtumą tarp kurso pradžios ir dabartinės datos (dienomis)
                   • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
                   */

                                               
                var kursuPradzia = new DateTime(2022, 06, 09);
                var kursuPabaiga = new DateTime(2022, 12, 31);
                TimeSpan KursuTrkme = kursuPabaiga - siandienosData;
                Console.WriteLine($"Kursai prasideda {kursuPradzia.ToShortDateString()} jie trunka {KursuTrkme.Days} ir baigiasi {kursuPabaiga.ToShortDateString()}");


                /*


                 Console.WriteLine("------------------------------------------------------------");
                 var kursoPradziosData = new DateTime(2022, 05, 30);
                 var kursoPabaigosData = new DateTime(2022, 12, 01);
                 TimeSpan kursoTrukme = siandienosData - kursoPradziosData;
                 Console.WriteLine("{0}\n{1}\n{2}",
                     kursoPradziosData.ToShortDateString(),
                     kursoPabaigosData.ToShortDateString(),
                     kursoTrukme.Days);
                 /*UŽDUOTIS
                ************************************************************************************************************************
                Sukurkite tris kintamuosius. tekstinio, sveiko skaitmens ir loginio tipo. 
                Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu
                */

                var tekstasKazkoks = "Veikia";
                var skaiciusKazkoks = 555;
                var loginisKazkoks = false;

                Console.WriteLine($"pirmas {tekstasKazkoks} antras {skaiciusKazkoks} trecias {loginisKazkoks} ");


                Console.WriteLine("------------------------------------------------------------");
                var tekstinioTipoKintamasis = "tekstinioTipoKintamasis";
                var sveikoSkaitmenoTipoKintamasis = 123;
                var loginioTipoKintamasis = true;
                Console.WriteLine($"{tekstinioTipoKintamasis} {sveikoSkaitmenoTipoKintamasis} {loginioTipoKintamasis}");

                /* UŽDUOTIS
              ************************************************************************************************************************
              Sukurkite tris sveikojo skaitmens tipo kintamuosius.
              Parašykite programą kuri į konsolę visus aprašytus kintamuosius atskiriant tarpu
              - panaudokite konkatinacija
              - panaudokite kompoziciją
              - panaudokite interpociacija
              */






            }
        }
    }
}
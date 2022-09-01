using P043_Uzduotys.Interfaces;
using P043_Uzduotys.Models.Concrete;
using P043_Uzduotys.Services;

namespace P043_Uzduotys
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            /*
            sukurkite interface IBookHtmlService kuris aprašo metodus
           - knygų iškodavimo iš html. Metodas <tipas> Decode(string dataSeed).   
           - knygų kodavimo į html. Metodas string Encode(list of Book). 
           sukurkite klasę/servisą BookService implementuojantį IBookHtmlService
           -implementuokite Decode unit-test 
           -Encode kolkas palikite neimplementuotą
            */

            /*
            tęskite darbą BookService klasėje
            -naudodami Extension Methods  implementuokite Encode unit-test 
            */



            /*
                sukurkite interface IUniversityBookStore 
               - void metodas Fill(dataSeed)
               - (BONUS) metodas FilterEBooks(string? title) grąžinantis (list of EBook)
               - (BONUS) metodas FilterAudioBooks(string? title) grąžinantis (array of AudioBook)
               - (BONUS) metodas FilterPaperbackBooks(string? title) grąžinantis (IEnumerable of PaperbackBook)
               - (BONUS) metodas FilterHardcoverBooks(string? title) grąžinantis (list of HardcoverBook)
               - metodas Buy(Book book, int qtty) padidantis knygų prekyboje kiekį jei tokia knyga jau yra, arba įtraukiantis naują knygą
               - metodas Sale(Person person, string title, BookType bookType, int qtty) sumažinantis nurodytų knygų prekyboje kiekį
                 ir grąžina tipą Invoce (tai nauja klasė, kurią reikia susigalvoti patiems)
                   <hint> pasižiūrėkite kokie properčiai yra Person ir UniversityBookStore klasėse. 
                   > Invoce klasėje privalo būti pirkimo "šiandien" data
                   > Invoce klasėje privalo būti Send() metodas kuris sąskaitą galės išsiųsti Sms, Email ir Post 
                     (siųsti galima nei vienu, vienu arba visais būdais. nustatoma konstruktoriuje) 
                     (paties siuntimo implementuoti nereikia)
                */
            /*
           sukurkite interface IUniversityBookStoreAccounting
          - metodas Stock() gąžinantis turimų knygų kiekį
          - metodas Genres() gąžinantis list of string (knygų žanrų sąrašą, tik unikalius įrašus)
          - metodas Sales() gąžinantis dictionary key=person, value=list of books (parduotas knygas)
           */

            Invoice invoce = new Invoice(null);
            Invoice invoce1 = new Invoice(new List<IInvoiceSenderService>());
            Invoice invoce2 = new Invoice(new List<IInvoiceSenderService>
            {
                new InvoiceSenderSms(),
            });
            Invoice invoce3 = new Invoice(new List<IInvoiceSenderService>
            {
                new InvoiceSenderSms(),
                new InvoiceSenderPost()
            });
            Console.WriteLine("-----------------");
            invoce.Send();
            Console.WriteLine("-----------------");
            invoce1.Send();
            Console.WriteLine("-----------------");
            invoce2.Send();
            Console.WriteLine("-----------------");
            invoce3.Send();
            Console.WriteLine("-----------------");
        }
    }
}
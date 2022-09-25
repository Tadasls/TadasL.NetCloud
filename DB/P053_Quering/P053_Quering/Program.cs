using P053_QueryingSqliteDb.Infrastrusture.DataBase;

namespace P053_Quering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var manageDd = new ManageDB();

            //manageDd.AddBlog("Programavimas");
            //manageDd.AddBlog("Knygos");
            //manageDd.AddPost("Charp", 1);
            //manageDd.AddPost("Charp", 2);

            // manageDd.AddAuthor("Petras", "Petrauskas", 1);


            manageDd.GetBlogs_EagerLoading();

            manageDd.LazyLoading();


            // SVARBU!!
            // PAGRINDINES CLI(PACKAGE MANAGER CONSOLE) KOMANDOS:
            // KOMANDOS TURI BUTI LEIDZIAMAS ANT INFRSTRUKTUROS PROJEKTO (Ten kur randasi DbContext)
            // add-migration "*MigrationName*"
            // update-database
            // update-database "*MigrationName*"

            // Pradedi naudoti SQLite turime isirasyti siuos NuGet (Tools->NuGet Package Manager->Manage NuGet...)
            // 1. install-package Microsoft.EntityFrameworkCore.Sqlite // Infrastructure
            // 2. install-package Microsoft.EntityFrameworkCore.Proxies // Infrastructure
            // 3. install-package Microsoft.EntityFrameworkCore.Tools // Presentation (Console application), Infrastructure

            // add-migration naudojame tada kada pasikeicia musu duombazes struktura


            /*
             * 
             
             Uzduotis 1 Sukurkite nauja programa ShoeShop. Si programa turetu tureti duombaze su 3 lentelemis:
           Shoes Id
Name[iki 100 simboliu, privalomas]
Type[iki10 simboliu, privalomas] // Moteriski, vyriski, vaikiski etc
Price
          ShoeSizeId
Size
Quantity
          SaleId
Shoe (Kurie buvo nupirkti)
Pairs (Kiek poru batu buvo nupirkta)
Sale taip pat turi tureti property PurchaseTotal, kuri neturetu atsirasti duombazeje ir turetu buti apskaiciuojama naudojant bato kaina * parduotas kiekis. Atsiminkite, kad siame kontekste vienas batu pora gali turetu daug dydziu (One to Many), batu dydis turetu tureti 1 pora batu (many to one), o pardavimas turetu tureti 1 batu dydi (Pagal kuri galesime atsekti programos pagalba reikalinga batu pora).
[Key]
[NotMapped]
[Required, MaxLength(100)]

Sukurkite klase ShoeShopRepository su jai priklausanciu interface, kurie leistu apsipirkti batus.
ShoeShopRepository metodai:
                public List<Shoe> GetAllShoes()
                public void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity)
public List<Sale> GetAllPurchases()
Tam, kad visus siuos reikalavimus igyvendintumete jums reikes uzsipildyti pradinius duomenis duomenu bazeje (batu kiekiai, dydziai ir t.t)
Sukurkite klase ShoeShop, kuri veiktu kaip jusu programine interface dalis (UI/ConsoleWriteline)
             
             */







        }
    }
}
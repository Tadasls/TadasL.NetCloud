
using P055_BatuParduotuve.Database;
using P055_DB_DataSeed.Database;

namespace HW02_ShoeShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ND BatuParduotuve!");

            using (var ctx = new ParduotuveContext())
            {
                //ctx.Database.EnsureCreated();
                var repository = new ParduotuveRepository(ctx);


            }
        }


        /*
         1. Sukurti programą Batų parduotuvė.
                
                Sukurti reikiamą duomenų bazę saugoti informacijai. Lentelės:
                - Batai (Id , Batu pavadinimas, Tipas (Moteriski Vyriski, Vaikiski) , Kaina)
                - BatuDydziai Id , dydis, kiekis)
                - Pardavimai ( Id , KokieBatai nupirkti, Kiek poru, kiek pinigų išleista.)
           Sukurti metodus, kurie:
                1. fiksuoja pirkimą
                - vartotojas pasirenka kokius batus perka, kokio dydžio, kiek porų
                - programa išsaugo pasikeitusius duomenis lentelėse BatuDydziai (kiekis sumažėja),
                - lentelėje Pardavimai užfiksuojamas pardavimas
         
         
         
         */





    }
}
using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models
{
    // Printer, postmail etc galetu buti naudojami generic metodu situacijoms
    public class GenericMethodBaseClass
    {
        // Apsiraseme generic metoda non-generic klaseje
        public bool Post<TPost>(TPost post) where TPost : IPost
        {
            // Pavyzdys butu jei noretume sukurti skaiciuotuva
            // ir noretume tikrinti, kad generic skaiciuotuvas
            // priima tik numeric tipo reiksmes, mums reiketu
            // papildomos validacijos, kuri tikrintu vistiek
            // i musu Generic Constraints range nepakliunancias
            // duomenu rusis/tipus pvz: DateTime
            if (typeof(TPost) == typeof(Tool)
                || typeof(TPost) == typeof(DateTime))
            {
                return false;
            }

            return true;
        }

        public void Print<T>(T printableData)
        {
            Console.WriteLine(printableData);
        }
    }
}

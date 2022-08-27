using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas
{
    
    public interface IMatematika
    {
        int Prideti(int skaicius);
        int Atimti(int skaicius);
        int Padauginti(int skaicius);
        double Padalinti(int skaicius);
        int PakeltiKvadratu();
        int PakeltiKubu();
    }

}

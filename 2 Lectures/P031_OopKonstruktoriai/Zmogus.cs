using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    // "class Zmogus" yra tas pats kas "internal class Zmogus"
    // "Klase" yra tas pats kas "Modelis"
    internal class Zmogus
    {
        public Zmogus() // tuscias koonstruktius
        {
            gimimoMetai = 1900;
            augintinis = new Augintinis();
            masinos = new List<string>();
            lytis = "Nezinoma";
        }

        // perduodama per parametrus fieldus
        public Zmogus(string vardas, string pavarde, int gimimoMetai, string lytis, string gimimoSalis)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            pilnasVardas = vardas + " " + pavarde;
            this.gimimoMetai = gimimoMetai;
            this.lytis = lytis;
            this.gimimoSalis = gimimoSalis;
        }


        // perduodame per zmogaus
        public Zmogus(Zmogus zmogus)
        {
            vardas = zmogus.vardas;
            pavarde = zmogus.pavarde;
            gimimoMetai = zmogus.gimimoMetai;
            lytis = zmogus.lytis;
            gimimoSalis = zmogus.gimimoSalis;
            pareigos = zmogus.pareigos;
            asmenybesTipas = zmogus.asmenybesTipas;
            akiuSpalva = zmogus.akiuSpalva;
        }






        // Klase aprasome tik public fieldais
        public string vardas;
        public string pavarde;
        public string pilnasVardas;
        public int gimimoMetai;
        public string pareigos;
        public string asmenybesTipas;
        public string akiuSpalva;
        public string lytis;
        public string gimimoSalis;
        public string megstamiausiasHobis;
        public double pinigai;
        public string issilavinimas;
        public List<string> masinos;
        public Augintinis augintinis;
    }
}

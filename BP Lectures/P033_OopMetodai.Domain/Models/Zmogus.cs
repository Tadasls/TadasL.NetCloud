using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033_OopMetodai.Domain.Models
{
    public class Zmogus
    {
        public Zmogus() { }
        public Zmogus(Bendrabutis gyvenamojiVieta)
        {
            gyvenamojiVieta.Gyventojai.Add(this); // Registruojame, kad musu dabartinis sukurtas <Zmogus> tampa gyventoju perduotame bendrabutyje
            GyvenamojiVieta = gyvenamojiVieta;
        }
        public Zmogus(string vardas)
        {
            Vardas = vardas;
        }
        // Sis konstruktorius kviecia/chainina kita konstruktoriu <public Zmogus(Bendrabutis gyvenamojiVieta)> ir priskiria gyventoja bendrabuciui
        public Zmogus(string vardas, Bendrabutis bendrabutis) : this(bendrabutis)
        {
            Vardas = vardas;
        }
        public string Vardas { get; set; }
        public Bendrabutis GyvenamojiVieta { get; set; } // Sis property dirba su <Bendrabutis> adresu
    }
}
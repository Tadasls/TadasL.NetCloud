using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P030_OopKompozicija
{
    internal class Masina
    {
        //tik properties apareme tik publis autoImpelmentas properties
        public string Gamintojas { get; set; }  
        public string Modelis { get; set; } // ctrl l   alt aukstyn zemyn
        public int GamybosMetai { get; set; } //crtl D kopijuoja
        public bool arDrausta { get; set; } // 
        public int duruKiekis { get; set; } 
        public string VariklioTipas { get; set; } 
        public double VariklioGalia { get; set; } 
        public double DidziausiasGreitis { get; set; } 
        public string Spalva { get; set; } 
        public double Aukstis { get; set; } 
        public int KedziuKiekis { get; set; } 

        public Apsaugossistema apsaugosSistema { get; set; }    


    }
}

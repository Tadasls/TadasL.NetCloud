using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P032_OopMetodai.Domain.Models
{
    public class Hobis
    {
        public Hobis()
        {

        }

        public Hobis(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }

        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string tekstasLietuviskai;

        public string TekstasLietuviskai
        {
            get { return tekstasLietuviskai; }
            private set { tekstasLietuviskai = value; }
        }

        public string tekstas;

        public string Tekstas
        {
            get { return tekstas; }
            private set { tekstas = value; }
        }



      


    }
}

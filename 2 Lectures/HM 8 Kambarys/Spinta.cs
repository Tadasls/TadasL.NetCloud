namespace HW_8_Kambarys
{
    public class Spinta
    {

        public Spinta()
        {

        }

        public Spinta(string pavadinimas, string medziaga, int aukstis, int plotis, int gylis)
        {
            Pavadinimas = pavadinimas;
            Medziaga = medziaga;
            Aukstis = aukstis;
            Plotis = plotis;
            Gylis = gylis;
        }

        public List<string> Drabuziai;


        private string pavadinimas;

        public string Pavadinimas
        {
            get { return pavadinimas; }
            set { pavadinimas = value; }
        }

        public string medziaga;

        public string Medziaga
        {
            get { return medziaga; }
            set { medziaga = value; }
        }

        public int aukstis;

        public int Aukstis
        {
            get { return aukstis; }
            set { aukstis = value; }
        }

        private int plotis;

        public int Plotis
        {
            get { return plotis; }
            set { plotis = value; }
        }

        public int gylis;

        public int Gylis
        {
            get { return gylis; }
            set { gylis = value; }
        }

        public string ParasytiAprasymaBaldo()
        {
            string baldoAprasymas = "Spintos paskirtis : " + Pavadinimas + ". Gamybai panaudota Medziaga yra " + Medziaga;
            Console.WriteLine(baldoAprasymas);
            return baldoAprasymas;
        }


    }
}
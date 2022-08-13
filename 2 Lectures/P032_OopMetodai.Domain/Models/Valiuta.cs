namespace P031_OopKonstruktoriai
{
    public class Valiuta
    {
        public Valiuta(string pavadinimas, int kursas, int ilgis, int plotis)
        {
            Pavadinimas = pavadinimas;
            Kursas = kursas;
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public string Pavadinimas { get; private set; }
        public int Kursas { get; private set; }
        public int Ilgis { get; private set; }
        public int Plotis { get; private set; }
    }
}
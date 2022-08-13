namespace HW_8_Kambarys
{
    public class Langas
    {
        public Langas()
        {

        }

        public Langas(string tipas, string medziaga, int aukstis, int plotis, string paketuGamintojas)
        {
            Tipas = tipas;
            Medziaga = medziaga;
            Aukstis = aukstis;
            Plotis = plotis;
            PaketuGamintojas = paketuGamintojas;
        }

        public string Tipas { get; set; }
        public string Medziaga { get; set; }
        public int Aukstis { get; set; }
        public int Plotis { get; set; }
        public string PaketuGamintojas { get; set; }


        public int PaskaiciuotiLanguKvadratura()
        {
            int langoKvadratura = Aukstis * Plotis;
            Console.WriteLine($"Lanko plotas cm2- {langoKvadratura/100}");
            return langoKvadratura; 
        }

    }
}
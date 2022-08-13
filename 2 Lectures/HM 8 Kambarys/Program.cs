namespace HW_8_Kambarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Mano Kambarys!");
            Metodas();
        }

        public static void Metodas()
        {
            Kambarys kambarys = new Kambarys();
            kambarys.spalva = "Balta";
            kambarys.numeris = 5;
            kambarys.aukstas = 1;
            kambarys.aukstis = 270;
            kambarys.plotas = 20;
            kambarys.languSkaicius = 2;
            kambarys.kaina = 200000;
            kambarys.sildymas = true;
            kambarys.kondicionierius = true;
            kambarys.balkonas = new Balkonas()
            {
                Tipas = "Atviras",
                Istiklintas = true,
                Sildymas = false,
                Aukstis = 250,
                Plotas = 90,
            };
            kambarys.langas = new Langas()
            {
                Tipas = "3M",
                Medziaga = "Plastikas",
                Aukstis = 200,
                Plotis = 100,
                PaketuGamintojas = "Amega",
            };
            kambarys.spinta = new Spinta()
            {
                Pavadinimas = "Miegamojo",
                Medziaga = "Medis",
                Aukstis = 150,
                Plotis = 120,
                Gylis = 60,


            };

            Console.WriteLine($"Jusu pasirinktas kambarios spalva yra {kambarys.spalva}  " +
                $" jam priskirtas {kambarys.numeris} numeris" +
                $"\n ir jis randasi : {kambarys.aukstas} aukste, \n pasirinkto kambario plotas yra: {kambarys.plotas}" +
                $"\n ir jame vaizdai jura zvelgsite pro {kambarys.languSkaicius} langus, sio kambario kaina tik {kambarys.kaina}");

           Console.WriteLine("papildoma info");
            kambarys.spinta.ParasytiAprasymaBaldo();
            kambarys.langas.PaskaiciuotiLanguKvadratura();
            kambarys.balkonas.PaskaiciuotiPlota();

        }





            /*  Namų darbas savaitgaliui.
           Susikurti “Kambarys” klasę ir aprašyti bent 10 objektų esančių jūsų kambaryje
          arba objektų kurie galėtų egzistuoti kambaryje kaip klases.
          Visos naujais aprašytos klasės turėtų turėti bent po 5 atributus 
          (Kontraktas/interfeisas) ir turėtų būti priskirtos kaip properties(savybe)
          “Kambarys” klasei.Bent 2 iš aprašytų klasių turėtų turėti kompoziciją su kitomis klasėmis
          pvz:”Kambarys” turi “Spinta”, kuri gali turėti List<Drabuzis>
          */

        
    }
}
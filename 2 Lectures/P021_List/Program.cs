namespace P021_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, List!");

            #region

            List<string> stringSarasas = new List<string>() { "zodis", "zodis2", "........." };
            List<int>  intSarasas = new List<int> { 1, 22, 33 ,44, 5};

            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };
            Console.WriteLine(string.Join(", ", automobiliai));
            //automobiliai.Add("BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            automobiliai[1] = "Subaru";
            Console.WriteLine(string.Join(", ", automobiliai));

            Console.WriteLine((automobiliai[2][0]));
            Console.WriteLine((automobiliai[2]));
            Console.WriteLine((automobiliai[2].Length));

            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("Listo Talpa " + automobiliai.Capacity);
            
            automobiliai.Add("BMW");
            Console.WriteLine("Listo Talpa " + automobiliai.Capacity);

            // Console.WriteLine(automobiliai[6]); uzlinks  Capasity reikalingas tik norint apriboti lista
          
            //Metodai
            //Prideda 1 elementa i gala
            automobiliai.Add("Citroen");
            Console.WriteLine(string.Join(", ", automobiliai));

            //Prideda daug elementa i gala
            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobiliai.AddRange(daugiauAutomobiliu);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine((automobiliai[5]));

            //isvalyti lista
            //automobiliai.Clear();
            //Console.WriteLine("isvalyta" + string.Join(", ", automobiliai));
            //Console.WriteLine("automobiliu kiekis " + automobiliai.Count);

            // istrinti elementa

            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5 " + automobiliai[5]);
            // Console.WriteLine("automobilis nr 5 " + automobiliai[4].Remove(2));

            //iterpimas
            Console.WriteLine("---------------");
            automobiliai.Insert(2, "BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5 " + automobiliai[5]);

            // paieska 
            Console.WriteLine("----------");
            bool arYraVw = automobiliai.Contains("VW");
            Console.WriteLine("Ar yra VW?" + arYraVw);
            bool arYraBmw = automobiliai.Contains("BMW");
            Console.WriteLine("Ar yra BMW?" + arYraBmw);

            //saraso sikiavimas sort
            automobiliai.Sort();
            Console.WriteLine(string.Join(", ", automobiliai));

            automobiliai.Sort((x,y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobiliai));



            intSarasas.Sort();
            Console.WriteLine(string.Join(", ", intSarasas));

            intSarasas.Sort((x,y) => y-x);
            Console.WriteLine(string.Join(", ", intSarasas));

            //paieskos funkcija find


           
            automobiliai.Add("VW");
            string pirmasKurYraV = automobiliai.Find(x=>x.Contains("VW"));
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("pir5mas automobilis kur yra V " + pirmasKurYraV);
            List<string> visiKurYraV = automobiliai.FindAll(x => x.Contains("V"));
            Console.WriteLine(string.Join(", ", automobiliai));

            List<int> a = intSarasas.FindAll(x => x > 6);
            Console.WriteLine(string.Join(", ", intSarasas));


            //pakeitimas is array i massiva ir atbulai

            string[] automobiliuMasyvas = automobiliai.ToArray();

            int[] intMasyvas = new int[] {1,2,3, 4, 5};
            List<int> skaiciai = intMasyvas.ToList();

#endregion



        }

        /* 1   DIDŽIAUSIAS SĄRAŠE
Duotas vienmatis sveikų skaičių sąrašas.
Parašykite programą, kuri suranda didžiausią skaičių saraše
{ 5, 1, 6, 8, 7 }
rezultatas: 8 */


        public static int DidziausiasSarase1(List<int> lst)
        {
            int max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }
            return max;
        }

        public static int DidziausiasSarase2(List<int> lst)
        {
            lst.Sort();                         
            return lst[lst.Count -1];
        }

      /* 2 DIDESNIS UŽ DIDŽIAUSIĄ
       Duotas vienmatis sveikų skaičių sąrašas.
       Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

       pvz:
       { 5, 1, 6, 8, 7 }
        rezultatas:  5, 1, 6, 8, 7, 9
      */

       
        public static List<int> DidziausiasSarase3(List<int> lst)
        {
            var max = DidziausiasSarase1(lst);
            lst.Add(max + 1);
            return lst;
        }

 
        public static List <int> DidziausiasSarase4(List<int> lst)

        {
            List<int> tmp = new List<int>();
            tmp.AddRange(lst);

            var max = DidziausiasSarase2(lst);
            lst.Add(max + 1);
            return lst;

        }








       

    }
}
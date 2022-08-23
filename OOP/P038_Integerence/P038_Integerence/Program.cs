using P038_Integerence.Models;

namespace P038_Integerence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hobby hobby1 = new Hobby(1, "Art", "Menas");  // 1 klases inicializacija per konstruktoriu // inicializacion with parameters
            Hobby hobby = new Hobby()     // 2 klases inicializacija per konstruktoriu per propercius // objekt initializer
            {
                Id = 2,
                Text = "Animation",
               TextLt = "Animacija"
            };


            Hobby hobby3 = new Hobby(); // inicializuojama tuscia klase/  properciai uzpildomi  //property assignent
            hobby3.Id = 3; 
            hobby3.Text = "Astrology";
            hobby3.TextLt = "Astrologija";







            


        }







        /*

                1- Sukurkite klase Hobby su properčiais
                           - Id 
                           - Text
                           - TextLt
                        2- Sukurkite konstruktorių be parametrų(pasiekiama visur)
                        3- Sukurkite konstruktorių su id, text, textLt parametrais(pasiekiama visur)
                        4- Skirtingais būdais inicializuokite klases.Įrašykite po 3 hobius.
                        5- Hobby klasėje sukurkite metodą kuris iškoduos HobbyInitialData.DataSeedCsv vieną įrašą (string)
                           ir užpildys properčius duomenimis.unit-test

                */
        /*
        sukurite klasę UniversityPerson paveldėtą iš Person klasės.Pridėkite properčius.
            - Profession (Profession)
            - Hobbies (List of Hobby)
            1- Padarykite metodą kuris atsitiktinai asmeniui pariks nuo 0 iki 4 hobių iš HobbyInitialData.DataSeedCsv.
            Užtikrinkite,kad tas pat hobis nepasikartotu 2 kartus
            2- Naudodami method overload padarykite metodus kurie atsitiktinai asmeniui pariks 1 profesiją iš
                ProfessionInitialData.DataSeed arba
                ProfessionInitialData.DataSeedCsvComma arba
                ProfessionInitialData.DataSeedCsvSemicolon.
            3- Padarykite metodą GetCsv() kuris grąžina string t.y.
               Iš užpildytos klasės UniversityPerson duomenų sukurs CSV formato DataSeed. Taip, kad galėtume naudoti jį vėliau.
    */


    }
}
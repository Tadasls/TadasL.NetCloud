namespace P034_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
           Sukurkite enum EGenderType su reikšmėmis 0 - MALE, 1 - FEMALE
           */

            /*
             
             Sukurkite klasę Person su properčiais:
          - Id(int), 
          - FirstName(string), 
          - LastName(string), 
          - FullName(readonly string - generuojamas iš FirstName ir LastName)
          - Gender(EGenderType - užpildomas tik inicializuojant klasę reikšme arba per metodą iš enumo EGenderType )
          - BirthDate (DateTime - gali būtu null)
          - Height (Decimal)
          - Weight (Decimal)
          - Age (readonly int - gali būti null. Generuojamas iš gimimo datos (BirthDate). Generavimui naudoti metodą) 
          - NameChanges (string - įrašomas tik iš vidaus. Pildomas pakeitus FirstName arba LastName. 
            Saugomi visi pakeitimai formatu "senas -> naujas" )
             
             */


            /*
         Sukurkite klasę Society
         1- Sukurkite propertį People (List of persons).
         2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
         3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
         4- Sukurkite properčius Men (List of persons)  ir Women (List of persons) . 
         5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test) 
         6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
         7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A. 
            Pagal Vardą arba Pavardę
              tokiu principu: SortByFirstName().Asc()
                              SortByLastName().Asc()
                              SortByLastName().Desc()
            <hint> return this
         */
        }
    }
}
using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=!");


int skaicius;
int kitasSkaicius = 20; //pradzia 20 
int nelyginisSkaicius = 5;

skaicius = 10;
kitasSkaicius = skaicius;    //kitasSkaicius tampa 10  
Console.WriteLine($"skaiciusyra  = {skaicius}, o kitasSkaisius yra = {kitasSkaicius}  ");

kitasSkaicius += nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius} ");  //rezultatas 15 t.y. 10 + 5

kitasSkaicius -= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius} ");  //rez is 15 - 5 gausis 10

kitasSkaicius *= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius} ");  //rez is 10 * 5 gausis 10

kitasSkaicius = 21; // isivedeme reiksme kad pakeistume kad nesidalintu is 5 

//counpund asignet operators
kitasSkaicius /= nelyginisSkaicius;

double doubleSkaicius = 21;
        
doubleSkaicius /= (double)nelyginisSkaicius;
Console.WriteLine($"doubleSkaicius patapes double = {doubleSkaicius} ");

Console.WriteLine("");

Console.WriteLine($"skaicius yra {skaicius} ir Kitas Skaicius {kitasSkaicius}");
Console.WriteLine("Matematiniai operatoriai  + - * / ++ -- ");


//sudetis
int suma = skaicius + kitasSkaicius;
Console.WriteLine("  suma = skaicius + kitasSkaicius = {0}", suma);

//atimtis
int atimtis = skaicius - kitasSkaicius;
Console.WriteLine("  suma = skaicius - kitasSkaicius = {0}", atimtis);

//daugyba
int daugyba = skaicius * kitasSkaicius;
Console.WriteLine("  suma = skaicius * kitasSkaicius = {0}", daugyba);

//dalyba
double dalyba = (double)skaicius / kitasSkaicius;
Console.WriteLine("  suma = skaicius / kitasSkaicius = {0}", dalyba);

int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

int dalybaSuLiekana = nelyginisSkaicius % 2;
Console.WriteLine($" dalybaSuLiekana = nelyginis kaicius % 2 =  {0}", dalybaSuLiekana );

skaicius++;
Console.WriteLine($"skaicius padidintas  ++ vienetu = {skaicius}");

skaicius--;
Console.WriteLine($"skaicius pamazintas -- vienetu = {skaicius}");

//uzdavinys trapecijos ploto skaiciavimas

double side1 = 5.5;
double side2 = 3.25;
double height = 4.6;

double area = (((side1 + side2) / 2 ) * height);

Console.WriteLine($"trapecijos plotas yra = {area}" );

Console.OutputEncoding = Encoding.UTF8;

int nulis = 0;
int int10 = 10;
long long10 = 10;
double double10 = 10;

// Console.WriteLine($" int10/nulis = {int10/nulis}"); //luzta
// Console.WriteLine($" long10/nulis = {long10 / nulis}"); //luzta
 Console.WriteLine($" dounle10/nulis = {double10 / nulis}"); //grazina = - t.y. begalybos implementacija 

double a = double.PositiveInfinity;
Console.WriteLine($"a = {a}");

Console.WriteLine($"a {a==double.PositiveInfinity}" );
Console.WriteLine($"a {a==double.NegativeInfinity}" );
Console.WriteLine($"a - 500 {a - 500}");

double a1 = double.NaN;

Console.WriteLine($"begalybe/=- {a/double.PositiveInfinity}");

//overFlow and underFlow


/*
short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);

Console.WriteLine($"s3 yra lygu = {s3}");

checked
{
    s3 = (short)(s1 + s2);
}
*/


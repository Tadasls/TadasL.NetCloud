// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Pirma uzduotis matematiniai veiksmai
Console.WriteLine();

Console.WriteLine("Iveskite skaiciu 1");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu 2");
double skaicius2 = double.Parse(Console.ReadLine()); // jei yra dalyba reikia double


Console.WriteLine($"{skaicius1}+{skaicius2}={skaicius1 + skaicius2}");
Console.WriteLine($"{skaicius1}-{skaicius2}={skaicius1 - skaicius2}");
Console.WriteLine($"{skaicius1}*{skaicius2}={skaicius1 * skaicius2}");
Console.WriteLine($"{skaicius1}/{skaicius2}={skaicius1 / skaicius2}");



//antra uzduotis suskaiciuoja 3 skaiciu vidurky


Console.WriteLine("Iveskite skaiciu 1");
int skaiciusA1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu 2");
int skaiciusA2 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu 3");
int skaiciusA3 = int.Parse(Console.ReadLine());

Console.WriteLine(" vidurkis yra = {0}", (double)(skaiciusA1 + skaiciusA2 + skaiciusA3) / 3);


//trecia uzduotis

long skaicius3Long = long.MaxValue;
short skaicius3Short = short.MaxValue;
Console.WriteLine();

Console.WriteLine($" skaiciusLong yra {skaicius3Long} skaiciusShort yra {skaicius3Short}");
Console.WriteLine();

Console.WriteLine($" padalinkite didesni skaiciu is mazesnio {(double)skaicius3Long / skaicius3Short}");

double rezultatas3 = (double)skaicius3Long / skaicius3Short;
Console.WriteLine(rezultatas3);


double rezultatas31 = (double)rezultatas3 - long.MaxValue;
Console.WriteLine(rezultatas31);

Console.WriteLine($" ir pridejus maxiInta = {rezultatas31 + int.MaxValue}");

//Console.WriteLine($" dalyba siu skaiciu  yra = {(double)(skaicius3Long / skaicius3Short)}");
//Console.WriteLine($" is rezultato atemus maxi Longa = {(double)(skaicius3Long / skaicius3Short) - long.MaxValue}");
//Console.WriteLine($" ir pridejus maxiInta = {(double)((skaicius3Long / skaicius3Short) - long.MaxValue) + int.MaxValue}");


//ketvirta uzduotis
/*PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
INT , SHORT, BYTE
STEBĖTI REZULTATĄ.
*/


//Console.WriteLine("----------------");

/*nuluztanti

double didelis10Skaicius = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine($" Int = {(int)didelis10Skaicius}");
Console.WriteLine($" SHORT = {(short)didelis10Skaicius}");
Console.WriteLine($" BYTE = {(byte)didelis10Skaicius}");
*/

//int sumazintasInt10Skaicius = Convert.ToInt32(didelis10Skaicius);
//short sumazintasShort10Skaicius = Convert.ToInt16(sumazintasInt10Skaicius);
//byte sumazintasByte10Skaicius = Convert.ToByte(sumazintasShort10Skaicius);

//Console.WriteLine(didelis10Skaicius);




/*
 3 salyga
sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių
*/


//5 programa Programa praso ivesti rutulio diametra o isveda plota ir turi


Console.WriteLine("Iveskite rutulio Diametra ir Spauskite Enter");
//double rutulioDiametras = Convert.ToDouble(Console.ReadLine());

var rutulioDiametras = double.Parse(Console.ReadLine());    
var Pi = 3.14;  //Rutulio ploto formule 4*pi * r kvadratu
var rutulioSpindulys = rutulioDiametras / 2;

Console.WriteLine($" Plotas Yra = {4 * Pi * rutulioSpindulys * rutulioSpindulys}");
Console.WriteLine($" Turis Yra = {(4 / 3) * Pi * (rutulioSpindulys * rutulioSpindulys * rutulioSpindulys)}");


// 6 programa greicio konvertavimas
Console.WriteLine("Iveskite metrus ir sekundes ");

var atstumasMetrais = double.Parse(Console.ReadLine());
var laikasSekundemis = double.Parse(Console.ReadLine());

var atstumasKilometrais = atstumasMetrais / 1000 ;
var laikasMinutemis = laikasSekundemis / 60;
var laikasValandomis = laikasMinutemis / 60;

Console.WriteLine($" Greitis KM/H = {atstumasKilometrais}/{laikasValandomis}");
Console.WriteLine($" Greitis KM/H = {atstumasKilometrais}/{laikasSekundemis}");



// 7 programa funkciju skaiciavimas
Console.WriteLine("Iveskite x ir y ");
var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());

var funkcija1 = (y + 2 * y + x + 1);
var funkcija2 = ((y * y) + (x / 2));

Console.WriteLine($" funkcija = {funkcija1}");
Console.WriteLine($" funkcija = {funkcija2}");


//patikrinimas ka ivedus Enter grazina 
//var d = Console.ReadLine(); 
//Console.WriteLine($" ar null {d == null}");
//Console.WriteLine($" ar empty {d == string.Empty}");

//astunta uzduotis pakeicia ivesto skaiciaus skaitmenis 1 arba visus

//Console.WriteLine("iveskite 5 skaicius");
//var vartotojoSkaicius = Convert.ToDouble(Console.ReadLine().Replace("1", "0"));
//Console.WriteLine($" {vartotojoSkaicius} / 2 = {vartotojoSkaicius /2}");

//devinta uzduotis


Console.WriteLine("iveskite 5 skaicius");
var vartotojoSkaicius = Convert.ToDouble(Console.ReadLine()

    .Replace("2", "0")
    .Replace("3", "0")
    .Replace("4", "0")
    .Replace("5", "0")
    .Replace("6", "0")
    .Replace("7", "0")
    .Replace("8", "0")
    .Replace("9", "0"));

Console.WriteLine($" {vartotojoSkaicius} / 2 = {vartotojoSkaicius / 2}");



//desimta uzduotis isveda skaiciu seka ivedus viena skaiciu

Console.WriteLine("iveskite 1 skaicius");
var vartSk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Rezultatas {++vartSk},{++vartSk},{++vartSk},{++vartSk},{++vartSk} ");









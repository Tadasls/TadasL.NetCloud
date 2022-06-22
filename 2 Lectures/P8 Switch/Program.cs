// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, switch!");

/*
Console.WriteLine($"iveskite meniu skaiciu 1,2,3,4");
int meniuChoise = Convert.ToInt32(Console.ReadLine());  // pavercia ivesti i skaicius

switch (meniuChoise)
{
   case 1:
  
        Console.WriteLine(" paspaudeme 1 punkta");
        Console.WriteLine(" papildoma info");
        break;

   case 2:
        Console.WriteLine(" nuspaudete 2 ");
        break;

   case 3:
        Console.WriteLine(" nuspaudete 3");
        break;

   case 4:
        Console.WriteLine(" nuspaudete 4 ");
        break;

    default:// kai nei viena salyga netenkinama
        { 
         Console.WriteLine("iveskite Kazka");
        var h = Console.ReadLine();

            switch (h)
            {
                case "":
                    Console.WriteLine("nieko neivesta");
                    break;
            }
      
        Console.WriteLine($"Klaida {h}");
        }
        break;
           // Console.WriteLine(h);
            }


//--------------------------
Console.WriteLine("--------------------");

var isvedamasRez = meniuChoise switch
{
    1 => "vartotas pasirinko 1",
    2 => "vartotas pasirinko 2",
   3 => "vartotas pasirinko 3",
   _ => "vartotas nieko nepasiriinko"

};
Console.WriteLine(isvedamasRez);


//--------------------------
Console.WriteLine("--------------------");

switch (meniuChoise)
{
    case 1:
    case 2:
        Console.WriteLine("vartotojas pasirinko 1 arba 2");
        break;
}
*/

//----------su ifais uzdavinys------ 

/*

Console.WriteLine("---if -- iveskite egzamino pazimy");
var meniuHitas = Convert.ToInt32(Console.ReadLine()); 
    if (meniuHitas >= 0 && meniuHitas <=4)
{
  Console.WriteLine($"NEPATEKINAMAI");
}
      
   else if (meniuHitas == 5)
        Console.WriteLine($"SILPNAI");
    else if (meniuHitas == 6)
        Console.WriteLine("PATENKINAMAI");
    else if (meniuHitas == 7)
        Console.WriteLine("VIDUTINIŠKAI");
    else if (meniuHitas == 8)
        Console.WriteLine("GERAI");
   else if (meniuHitas == 9)
        Console.WriteLine("LABAI GERAI");
   else if (meniuHitas == 10)
        Console.WriteLine("PUIKIAI");
    else Console.WriteLine($"nera tokio pazymio {meniuHitas}");




//--------------------- naujas su 

Console.WriteLine($"iveskite pazimi nuo 0 iki 10");
int meniuHit = Convert.ToInt32(Console.ReadLine());  // pavercia ivesti i skaicius

switch (meniuHit)
{
    case 0:
    case 1:
    case 2:
    case 3:
        Console.WriteLine("NEPATEKINAMAI");
        break;
    case 4:
        Console.WriteLine("NEPATEKINAMAI");
        break;
    case 5:
        Console.WriteLine("SILPNAI");
        break;
    case 6:
        Console.WriteLine("PATENKINAMAI");
        break;
    case 7:
        Console.WriteLine("VIDUTINIŠKAI");
        break;
    case 8:
        Console.WriteLine("GERAI");
        break;
    case 9:
        Console.WriteLine("LABAI GERAI");
        break;
    case 10:
        Console.WriteLine("PUIKIAI");
        break;
    default:
        Console.WriteLine($"nera tokio pazymio {meniuHit}");
        break;
}


//---------------

Console.WriteLine("kazka padarysi switc expreson");

Console.WriteLine(meniuHit switch
{
    0 or 1 or 2 or 3 =>"NEPATEKINAMAI",
     
        5 => "SILPNAI",
        6 => "PATENKINAMAI",
        7 => "VIDUTINIŠKAI",
        8 =>"GERAI",
        9 =>"LABAI GERAI",
        10 => "PUIKIAI",
        _ => null
          
   });

*/

// ketvirtas uzdavinys
/*
Console.WriteLine("Iveskite kiek puodeliu nusipirko");
var pardavimoOperacija = Convert.ToInt32(Console.ReadLine());


if (pardavimoOperacija >= 3)
{
    int nemokamiPuodai = pardavimoOperacija / 3;
    Console.WriteLine($"Pirkejui priklauso {nemokamiPuodai} nemokami kavos puodeliai ");

} else
{
    Console.WriteLine("Pirkejui nepriklauso nemokama kava");
}
*/
/*
Console.WriteLine("iveskite perkamu kavos puodeliu kieki");
var input = Convert.ToInt32(Console.ReadLine());
var kava = input / 3;
Console.WriteLine(input / 3 == 0 ? "nepriklauso" :$"priklauso {kava}");
*/
// uzdavinio variantas su salyginiu

/*
Console.WriteLine("Iveskite 4 sveikus skaicius");
var skaicius1 = Convert.ToInt32(Console.ReadLine());
var skaicius2 = Convert.ToInt32(Console.ReadLine());
var skaicius3 = Convert.ToInt32(Console.ReadLine());
var skaicius4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(skaicius1 != 0 ? $"{skaicius1} -> {skaicius1 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius2} -> {skaicius2 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius3} -> {skaicius3 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius4} -> {skaicius4 * -1}" : $" 0 => N/A");

*/

/*
if (skaicius1 > 0)
{
    Console.WriteLine($"ivedus teigiama skaicius {skaicius1} -> gauname neigiama {skaicius1 * -1} ");
} else if (skaicius1 <  0)
{
    Console.WriteLine($"ivedus neigiama skaiciu {skaicius1} -> gauname teigiama {skaicius1 * -1} ");
} else { Console.WriteLine($"{skaicius1}  -> N/A"); }
if (skaicius2 > 0)
{
    Console.WriteLine($"ivedus teigiama skaicius {skaicius2} -> gauname neigiama {skaicius2 * -1} ");
}
else if (skaicius2 < 0)
{
    Console.WriteLine($"ivedus neigiama skaiciu {skaicius2} -> gauname teigiama {skaicius2 * -1} ");
}
else { Console.WriteLine($"{skaicius2}  -> N/A"); }
if (skaicius3 > 0)
{
    Console.WriteLine($"ivedus teigiama skaicius {skaicius3} -> gauname neigiama {skaicius3 * -1} ");
}
else if (skaicius3 < 0)
{
    Console.WriteLine($"ivedus neigiama skaiciu {skaicius3} -> gauname teigiama {skaicius3 * -1} ");
}
else { Console.WriteLine($"{skaicius3}  -> N/A"); }
if (skaicius4 > 0)
{
    Console.WriteLine($"ivedus teigiama skaicius {skaicius4} -> gauname neigiama {skaicius4 * -1} ");
}
else if (skaicius4 < 0)
{
    Console.WriteLine($"ivedus neigiama skaiciu {skaicius4} -> gauname teigiama {skaicius4 * -1} ");
}
else { Console.WriteLine($"{skaicius4}  -> N/A"); }
*/

/* reikia patobulinti
    int nezinomasisSkaicius = 12;

Console.WriteLine("atspekite skaiciu nuo 0 iki 21 per 6 karts");
var ivestasSkaicius1 = Convert.ToInt32(Console.ReadLine());

if (ivestasSkaicius1 == nezinomasisSkaicius) 
{Console.WriteLine($"Atspejote");}
else if (ivestasSkaicius1 > nezinomasisSkaicius)
{Console.WriteLine($"{ivestasSkaicius1} yra didesnis");}
else if (ivestasSkaicius1 < nezinomasisSkaicius) 
{Console.WriteLine($"{ivestasSkaicius1} yra mazesnis");}

    var ivestasSkaicius2 = Convert.ToInt32(Console.ReadLine());
if (ivestasSkaicius2 == nezinomasisSkaicius)
{ Console.WriteLine($"Atspejote"); }
else if (ivestasSkaicius2 > nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius2} yra didesnis"); }
else if (ivestasSkaicius2 < nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius2} yra mazesnis"); }

var ivestasSkaicius3 = Convert.ToInt32(Console.ReadLine());
if (ivestasSkaicius3 == nezinomasisSkaicius)
{ Console.WriteLine($"Atspejote"); }
else if (ivestasSkaicius3 > nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius3} yra didesnis"); }
else if (ivestasSkaicius3 < nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius3} yra mazesnis"); }

var ivestasSkaicius4 = Convert.ToInt32(Console.ReadLine());
if (ivestasSkaicius4 == nezinomasisSkaicius)
{ Console.WriteLine($"Atspejote"); }
else if (ivestasSkaicius4 > nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius4} yra didesnis"); }
else if (ivestasSkaicius4 < nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius4} yra mazesnis"); }

var ivestasSkaicius5 = Convert.ToInt32(Console.ReadLine());
if (ivestasSkaicius5 == nezinomasisSkaicius)
{ Console.WriteLine($"Atspejote"); }
else if (ivestasSkaicius5 > nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius5} yra didesnis"); }
else if (ivestasSkaicius5 < nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius5} yra mazesnis"); }

var ivestasSkaicius6 = Convert.ToInt32(Console.ReadLine());
if (ivestasSkaicius6 == nezinomasisSkaicius)
{ Console.WriteLine($"Atspejote"); }
else if (ivestasSkaicius6 > nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius6} yra didesnis"); }
else if (ivestasSkaicius6 < nezinomasisSkaicius)
{ Console.WriteLine($"{ivestasSkaicius6} yra mazesnis"); }

*/
//su if ir su swift
/*

Console.WriteLine("įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )");
var imput1 = Convert.ToDouble(Console.ReadLine());
var imput2 = Convert.ToDouble(Console.ReadLine());
var imput0 = (Console.ReadLine());

if (imput0 == "+")
{
    Console.WriteLine($" suma = {imput1 + imput2}");
} else if (imput0 == "-")
{
    Console.WriteLine($" atimtis = {imput1 - imput2}");
}
else if (imput0 == "*")
{
    Console.WriteLine($" sandauga = {imput1 * imput2}");
}
else if (imput0 == "/")
{
    Console.WriteLine($" dalyba = {(double)imput1 / imput2}");
}




//var imputB0 = (Console.ReadLine());

switch (imput0)
{
    case "+":
        Console.WriteLine($" suma = {imput1 + imput2}");
        break;

    case "-":
        Console.WriteLine($" atimtis = {imput1 - imput2}");
        break;
    case "*":
        Console.WriteLine($" sandauga = {imput1 * imput2}");
        break;
    case "/":
        Console.WriteLine($" dalyba = {(double)imput1 / imput2}");
        break;
}
*/

// uzduotis nauja

/*
Console.WriteLine("įvesti tris vardus ");
var vardasA = Console.ReadLine();
var vardasB = Console.ReadLine();
var vardasC = Console.ReadLine();

Console.WriteLine("Iveskite ju amziu");
int amziusA = Convert.ToInt32(Console.ReadLine());
int amziusB = Convert.ToInt32(Console.ReadLine());
int amziusC = Convert.ToInt32(Console.ReadLine());

int vidurkis = (amziusA + amziusB + amziusC) / 3;

Console.WriteLine($" Pirmas {vardasA} jam metu {amziusA}");
Console.WriteLine($" Antras {vardasB} jam metu {amziusB}");
Console.WriteLine($" Trecias {vardasC} jam metu {amziusC}");

Console.WriteLine($"Vidurkis amziaus {vidurkis}");

//iesko seno
if (amziusA > amziusB && amziusA > amziusC)
{ Console.WriteLine(" A vyriausias"); }
else if (amziusB > amziusA && amziusB > amziusC)
{    Console.WriteLine("B Vyriausias"); }
else if (amziusC > amziusA &&  amziusC > amziusB)
{   Console.WriteLine("C vyriausias");}

//iesko jauno

if (amziusA < amziusB && amziusA < amziusC)
{ Console.WriteLine(" A jauniausias"); }
else if (amziusB < amziusA && amziusB < amziusC)
{ Console.WriteLine("B jauniausias"); }
else if (amziusC < amziusA && amziusC < amziusB)
{ Console.WriteLine("C jauniausias"); }

*/


// kita uzduotis
/*
**Kalėdų sausainiai * *
-Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
-Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
-Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
- Jei nėra išveda - "Palaukite kalėdų"
Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
< Hint > metodai data.Month ir data.Day
   */

Console.WriteLine("įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)");
//var metai1 = DateOnly.Parse(Console.ReadLine());

var metai1 = DateTime.Parse(Console.ReadLine());
var metai2 = DateTime.Parse(Console.ReadLine());
var metai3 = DateTime.Parse(Console.ReadLine());
var metai4 = DateTime.Parse(Console.ReadLine());

Console.WriteLine($"{metai1.ToString("yyyy-MM-dd")}, {metai2.ToString("yyyy-MM-dd")}, {metai3.ToString("yyyy-MM-dd")}, {metai4.ToString("yyyy-MM-dd")}");

//string kale1 = metai1[^5..];

if (metai1.Month == 12 && metai1.Day == 24)
 Console.WriteLine(" got some cokies");
else if (metai2.Month == 12 && metai2.Day == 24)
    Console.WriteLine(" got some cokies");
else if (metai3.Month == 12 && metai3.Day == 24)
    Console.WriteLine(" got some cokies");
else if (metai4.Month == 12 && metai4.Day == 24)
    Console.WriteLine(" got some cokies");
else
    Console.WriteLine("no cokies wait");





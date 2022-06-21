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

Console.WriteLine("Iveskite 4 sveikus skaicius");
var skaicius1 = Convert.ToInt32(Console.ReadLine());
var skaicius2 = Convert.ToInt32(Console.ReadLine());
var skaicius3 = Convert.ToInt32(Console.ReadLine());
var skaicius4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(skaicius1 != 0 ? $"{skaicius1} -> {skaicius1 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius2} -> {skaicius2 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius3} -> {skaicius3 * -1}" : $" 0 => N/A");
Console.WriteLine(skaicius1 != 0 ? $"{skaicius4} -> {skaicius4 * -1}" : $" 0 => N/A");


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


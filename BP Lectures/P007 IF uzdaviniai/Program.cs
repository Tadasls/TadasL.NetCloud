﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, If'ai!");

//uzduotis 1

Console.WriteLine($"iveskite skaiciu", Console.ReadLine());
int ivestisA = Convert.ToInt32(Console.ReadLine());

if (ivestisA % 2 == 0) // skaiciuoja ar yra liekana dalinant is dvieju jei nelieka tai lyginis

{
    Console.WriteLine("Skaicius lyginis");
}

if (ivestisA < 0) // tikrina ar nera neigiamas

{
    Console.WriteLine("skaicius neigiamas");
}

if (ivestisA % 2 != 0 && ivestisA > 0) // tikrina ar lyginis ir ar teigiamas
{
    Console.WriteLine("Skaisius" + ivestisA);
}



// uzduotis nr 2


Console.WriteLine($"iveskite grupes nariu skaiciu");
int ivestisB = Convert.ToInt32(Console.ReadLine());  // pavercia ivesti i skaicius

if (ivestisB == 1)
    Console.WriteLine(" tai solo atlikejas");
else if (ivestisB == 2)
    Console.WriteLine(" tai duetas");
else if (ivestisB > 2 && ivestisB < 10)
    Console.WriteLine("tai ansamblis");
else if (ivestisB >= 10)
    Console.WriteLine("tai kamerinis ansamblis");
else
{
    Console.WriteLine("klaida");
}



// 3 uzduotis 

int ivestis3; //kitoje bugina
Console.WriteLine($"iveskite isdirbtas valandas");
bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out  ivestis3); // kazkokia kieta funkcija



if (arGerasSkaicius)
  

    if (ivestis3 < 160)
    {
        Console.WriteLine($"dar reikia isdirbti  {160 - ivestis3} val");
    }
    else if (ivestis3 == 160)
    {
        Console.WriteLine("isdirbtas Etapas");
    }
    else if (ivestis3 > 160)
    {
        Console.WriteLine($"virsvalandziu  {ivestis3 - 160} val");
    }
    else
    {
        Console.WriteLine("klaida");
    }





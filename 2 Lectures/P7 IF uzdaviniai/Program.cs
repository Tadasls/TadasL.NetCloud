﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//uzduotis 1

Console.WriteLine($"iveskite skaiciu", Console.ReadLine());
int ivestisA = Convert.ToInt32(Console.ReadLine());

if (ivestisA % 2 == 0)

{
    Console.WriteLine("Skaicius lyginis");
}


if (ivestisA < 0)

{
    Console.WriteLine("skaicius neigiamas");
}

if (ivestisA % 2 != 0 && lyginisSkaicius > 0)
{
    Console.WriteLine("Skaisius" + ivestisA);
}



// uzduotis nr 2


Console.WriteLine($"iveskite grupes nariu skaiciu");
int ivestisB = Convert.ToInt32(Console.ReadLine());

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


Console.WriteLine($"iveskite isdirbtas valandas");
bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int input);
int imput;
if (arGerasSkaicius)

    if (input < 160)
    {
        Console.WriteLine($"dar reikia isdirbti  {160 - input} val");
    }
    else if (input == 160)
    {
        Console.WriteLine("isdirbtas Etapas");
    }
    else if (input > 160)
    {
        Console.WriteLine($"virsvalandziu  {input - 160} val");
    }
    else
    {
        Console.WriteLine("klaida");
    }
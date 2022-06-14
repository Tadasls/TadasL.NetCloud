// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, operatoriai !");


//Reliaciniai operatoriai == != > < >= <=

var skaicius = 10;
var nelyginisSkaicius = 5;
var lyginisSkaicius = 10;

Console.WriteLine(" == patikrina ar kintamieji yra lygūs");
Console.WriteLine($" {skaicius}=={lyginisSkaicius} yra {skaicius == lyginisSkaicius}");
bool ar10yraLygu5 = skaicius == nelyginisSkaicius;

Console.WriteLine($" {skaicius}=={nelyginisSkaicius} yra {ar10yraLygu5}");

Console.WriteLine("-----------------------------------");
Console.WriteLine(" != patikrina ar kintamieji yra nelygūs");
Console.WriteLine($" {skaicius}!={lyginisSkaicius} yra {skaicius != lyginisSkaicius}");
Console.WriteLine($" {skaicius}!={nelyginisSkaicius} yra {skaicius != nelyginisSkaicius}");

Console.WriteLine("-----------------------------------");
Console.WriteLine(" > patikrina ar kairėje esanti reikšmė yra didensė už dešinėje");
Console.WriteLine($" {skaicius}>{lyginisSkaicius} yra {skaicius > lyginisSkaicius}");
Console.WriteLine($" {skaicius}>{nelyginisSkaicius} yra {skaicius > nelyginisSkaicius}");

Console.WriteLine("-----------------------------------");
Console.WriteLine(" < patikrina ar kairėje esanti reikšmė yra mazesne už dešinėje");
Console.WriteLine($" {skaicius}<{lyginisSkaicius} yra {skaicius < lyginisSkaicius}");
Console.WriteLine($" {skaicius}<{nelyginisSkaicius} yra {skaicius < nelyginisSkaicius}");

Console.WriteLine("-----------------------------------");
Console.WriteLine(" >= patikrina ar kairėje esanti reikšmė yra didensė arba lygi už dešinėje");
Console.WriteLine($" {skaicius}>={lyginisSkaicius} yra {skaicius >= lyginisSkaicius}");
Console.WriteLine($" {skaicius}>={nelyginisSkaicius} yra {skaicius >= nelyginisSkaicius}");

Console.WriteLine("-----------------------------------");
Console.WriteLine(" <= patikrina ar kairėje esanti reikšmė yra mažesnė arba lygi už dešinėje");
Console.WriteLine($" {skaicius}<={lyginisSkaicius} yra {skaicius <= lyginisSkaicius}");
Console.WriteLine($" {skaicius}<={nelyginisSkaicius} yra {skaicius <= nelyginisSkaicius}");



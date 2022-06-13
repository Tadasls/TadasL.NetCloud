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




double doubleSkaicius = 21;
    
    
doubleSkaicius /= (double)nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius patapes double = {doubleSkaicius} "); 






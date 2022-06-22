// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, String manipuliacijos!");

/*
Console.WriteLine("kazkas"); //metodas nieko negrazina / negrazina reiksmes
var b = Console.ReadLine();  //grazina reiksme ir ja galima priskirti
ConsoleKeyInfo c = Console.ReadKey();
var a = 1 > 2 ? "kazkas" : "kitas";
Console.WriteLine(a);
*/
Console.WriteLine("String Manipuliacijos ");
Console.WriteLine(" string konstruktor");
string vardas = "Petras";
char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //array
string greetings = new string(letters); //string konstruktorius
DateTime siandiena = DateTime.Today;


Console.WriteLine(greetings[1]);  // paima viena raide jei lauzdiniuose skliaustuose
Console.WriteLine(letters[2]); // nereprentatyvu del magijos po kapisonu 
Console.WriteLine(greetings.Substring(1,2));  // paima 
Console.WriteLine(vardas[2]); //paiims is vardo 2 t raide

                                  //---------------------------------- konkatinacija stringu
Console.WriteLine("************** String concatination");
var pilnasVardas = vardas + " Pavardenis"; // paliktas separatorius
Console.WriteLine(pilnasVardas);

//---------------------------------- kompozicija stringu
Console.WriteLine("************** String composition");
var vardasIrData = string.Format("{0} data = {1}", vardas, siandiena);
Console.WriteLine(vardasIrData);

//----------------------------------  stringu interpoliacija
Console.WriteLine("************** String interpolacion");
var vardasIrData1 = $" vardas {vardas} ir data  {siandiena}";
Console.WriteLine(vardasIrData);

//-------------------------------stringo trys busenos 
Console.WriteLine("-----------------------");
string? nullas = null;
string baltaErdve = "           ";  // tarpas be informacijos
string tuscia = string.Empty;
string tuscia1 = "";

Console.WriteLine("ar \"\" yra tapatu string.Empty? {0}", tuscia == tuscia1);
Console.WriteLine("ar \"\" yra tapatu baltar.Empty? {0}", tuscia == baltaErdve);

bool arTuscia = string.IsNullOrEmpty(tuscia);
Console.WriteLine($"arTuscia={arTuscia}");


bool arNullas = string.IsNullOrEmpty(nullas);
Console.WriteLine($"arNullas = {arNullas}");


bool arBaltaErveYraTuscia = string.IsNullOrEmpty(baltaErdve);
Console.WriteLine($"arBaltaErdveYraTuscia = {arBaltaErveYraTuscia}");


bool arBaltaErdve = string.IsNullOrWhiteSpace(baltaErdve);
Console.WriteLine($"arBaltaErdve ={arBaltaErdve}");

//----------------
Console.WriteLine("-----------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"eilute {Environment.NewLine} nauja ";
string aa5 = $"kelias diskineje sistemoje {Path.DirectorySeparatorChar}program file{Path.DirectorySeparatorChar}windows ";
string aa6 = $"{{    }}";
string aa7 = @" galima 
rasyti teksta
per kelias 
\ {@ "" //tik kabutes
eilutes";


Console.WriteLine(aa1);
Console.WriteLine(aa2);
Console.WriteLine(aa3);
Console.WriteLine(aa4);
Console.WriteLine(aa5);
Console.WriteLine(aa6);
Console.WriteLine(aa7);


//--------------------

Console.WriteLine("-------------------");

double skaicius = 6.5135151315;






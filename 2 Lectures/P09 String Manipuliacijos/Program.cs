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
Console.WriteLine(DateTime.Today.ToShortDateString());

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
var vardasIrData = string.Format("{0} data = {1}", vardas, siandiena);  // kaip Format veikia????
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

double skaicius = 66553.5135151315;
string skaiciusSuApribotuSkaiciumPoKablelio = skaicius.ToString("0.00");
Console.WriteLine(skaiciusSuApribotuSkaiciumPoKablelio + 8888888); // suapvalino po kablelio ir tiesiog prideda
Console.WriteLine(double.Parse(skaiciusSuApribotuSkaiciumPoKablelio) + 8888888); // ssugrazina i skaiciu ir prideda

//--------------------

Console.WriteLine("-------------------");

//  pasiekimas kitos programos P10_Metodai.Program.IsveskTekstaEkranan();


//-----------------------
Console.WriteLine("------------------------------------");

Console.WriteLine("******** TryParse ******** ");

string v1 = null;
string v2 = "160519";
string v3 = "9432.0";
string v4 = "16,667";
string v5 = "   -322     ";
string v6 = " +4302";
string v7 = "(100)";
string v8 = "01FA";
string v9 = "0x01FA";
string v10 = "001";

bool success1 = int.TryParse(v1, out int number1);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v1, success1);
bool success2 = int.TryParse(v2, out _);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v2, success2);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v3, double.TryParse(v3, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v4, double.TryParse(v4, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v5, int.TryParse(v5, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v6, int.TryParse(v6, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v7, int.TryParse(v7, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v8, int.TryParse(v8, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v9, int.TryParse(v9, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v10, int.TryParse(v10, out _));

//--------------------------------------
//STRING METODAI
Console.WriteLine("-----------------------------------------");
Console.WriteLine("******** Clone() string dalies klonavimas ******** ");
{
    var vardas_2 = vardas.Clone();
    var vardas_3 = vardas;
    Console.WriteLine($"klonuotas vardas {vardas_2} ");
}
//-----------------------
{
    Console.WriteLine("******** CompareTo() string palyginimas ********");
    string strFirst = "Goodbye";
    string strSecond = "Hello";
    int cmpVal = strFirst.CompareTo(strSecond);
    //grazins -1 jei strFirst < strSecond
    //grazins 0 jei strFirst = strSecond
    //grazins 1 jei strFirst > strSecond
}
//-----------------------
var netvarkingasTekstas = " Kazkoks NEtvarkingAS Tekstas Su tarPais ir 155 0051 skaičiais ";

{
    Console.WriteLine("******** Contains() paieška string viduje ******** ");
    string etr = " etr";
    Console.WriteLine($"ar vardas {vardas} viduje turi {etr}? {vardas.Contains(etr)}");
    Console.WriteLine($"ar vardas {netvarkingasTekstas} viduje turi 'AS Te'? {netvarkingasTekstas.Contains("AS Te")}");
}
//-----------------------
{
    Console.WriteLine("******** EndsWith() paieška string gale ******** ");
    Console.WriteLine($"ar vardas {vardas} pradideda 'nas'? {vardas.EndsWith("nas")}");
    Console.WriteLine($"ar vardas {vardas} pradideda 'ras'? {vardas.EndsWith("ras")}");
}
//-----------------------
{
    Console.WriteLine("******** Equals() string palyginimas ********");
    string vardasIsMazosios = "petras";
    bool arVardaiLygus = vardas == vardasIsMazosios;
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios}? {arVardaiLygus}");
    bool arVardaiLygus1 = vardas.Equals(vardasIsMazosios, StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios} su IgnoreCase: {arVardaiLygus1}");
}
//-----------------------
{
    Console.WriteLine("******** IndexOf() grąžina indeksą pirmo sutikto atitikmens ******** ");
    Console.WriteLine(netvarkingasTekstas);
    Console.WriteLine("e raidės indeksas " + netvarkingasTekstas.IndexOf("e")); //grazina 23
    Console.WriteLine("a raidės indeksas " + netvarkingasTekstas.IndexOf("a")); //grazina 2
    Console.WriteLine("x raidės indeksas " + netvarkingasTekstas.IndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** ToLower() visas raides padaro mažosiom ******** ");
    var tekstasSuTarpaisMazosiomis = netvarkingasTekstas.ToLower();
    Console.WriteLine($"tekstasSuTarpais mažosiomis ({tekstasSuTarpaisMazosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** ToUpper() visas raides padaro didziosiom ******** ");
    var tekstasSuTarpaisDidziosiomis = netvarkingasTekstas.ToUpper();
    Console.WriteLine($"tekstasSuTarpais didžiosiomis ({tekstasSuTarpaisDidziosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** Insert() įterpia teksta nurodytoje vietoje ******** ");
    Console.WriteLine(vardas.Insert(2, "_Hello_"));
}
//-----------------------
{
    Console.WriteLine("******** LastIndexOf() grąžina indeksą paskutinio sutikto atitikmens ******** ");
    Console.WriteLine("e raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("e")); //grazina 23
    Console.WriteLine("a raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("a")); //grazina 59
    Console.WriteLine("x raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** Length string ilgis (simboliu kiekis)  ********");
    Console.WriteLine(vardas.Length);
}
//-----------------------
{
    Console.WriteLine("******** Remove() pašalna simbolius  ********");
    Console.WriteLine(vardas.Remove(2)); //iki galo

    Console.WriteLine(vardas.Remove(0, 1)); //kiek nurodyta
    Console.WriteLine(vardas.Remove(vardas.Length - 1, 1));
}
//-----------------------
{
    Console.WriteLine("******** Replace() raidžių keitimas string viduje ******** ");
    var pakeistasaTekstas = netvarkingasTekstas.Replace("a", "_=_");
    Console.WriteLine($"pakeistasa tekstas {pakeistasaTekstas} ");
}
//-----------------------
{
    Console.WriteLine("******** Split() teksto skaidymas ******** ");
    string[] split = vardas.Split('e'); //Split the string based on specified value
    Console.WriteLine(split[0]);
    Console.WriteLine(split[1]);
}
//-----------------------
Console.WriteLine("******** StartsWith() paieška string pradžioje ******** ");
{
    Console.WriteLine($"ar vardas {vardas} pradideda 'Jon'? {vardas.StartsWith("Jon")}");
}
//-----------------------
{
    Console.WriteLine("******** Substring() dalies string nuskaitymas ******** ");
    var dalisTeksto = netvarkingasTekstas.Substring(2);
    Console.WriteLine($"dalis teksto {dalisTeksto} ");

    var dalisTeksto1 = netvarkingasTekstas.Substring(2, 10);
    Console.WriteLine($"dalis teksto {dalisTeksto1} ");
}
//-----------------------
{
    Console.WriteLine("******** Trim() tekstas su tarpais trim ******** ");

    Console.WriteLine($"tekstasSuTarpais ({netvarkingasTekstas}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ir priekyje ({netvarkingasTekstas.Trim()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais priekyje  ({netvarkingasTekstas.TrimStart()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ({netvarkingasTekstas.TrimEnd()}).");

}



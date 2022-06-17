// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, savarankiskas Tado Darbas 001 !");

Console.WriteLine("įveskite - temperatūrą Celsijais.");

var tempC = Convert.ToDouble(Console.ReadLine()); // nuskaito ivedima
var tempF = (tempC * 9 / 5) + 32;
var tempK = tempC + 273.16;

var tempCPerskIsF = (tempF - 32) / 1.8;
var tempCPerskIsK = tempK - 273.16;
var tempKPerskIsF = (((tempF - 32) / 1.8) + 273.16);

bool patikrinimas1 = tempC == tempCPerskIsF;
bool patikrinimas2 = tempC == tempCPerskIsK;
bool patikrinimas3 = tempKPerskIsF == tempK;


Console.WriteLine($" Temp Farenfeitais  - {tempF}"); //išveda į ekraną temperatūrą pagal farenheitą.
Console.WriteLine($" Temp Kelvinais  - {tempK}"); //išveda į ekraną temperatūrą pagal kelviną.

Console.WriteLine($" Temp Celsijais is Farenheitu  - {tempCPerskIsF}"); //išveda į ekraną konvertuota temperatūrą 
Console.WriteLine($" Temp Celsijais is Kelvinu - {tempCPerskIsK}");
Console.WriteLine($" Temp Kelvinais is Farenheitu - {tempKPerskIsF}");

Console.WriteLine($" ar sutapima konvertuota C is F ? {patikrinimas1}"); //patikrinimas 1
Console.WriteLine($" ar sutapima konvertuota C is K ? {patikrinimas2}"); //patikrinimas 2
Console.WriteLine($" ar sutapima konvertuota C is K ? {patikrinimas3}"); //patikrinimas 3


// pokyciu kintamieji
var k1 = 40;
var k2 = 35;
var k3 = 30;
var k4 = 25;
var k5 = 20;
var k6 = 15;
var k7 = 10;
var k8 = 5;
var k9 = 0;
var k10 = -5;
var k11 = -10;
var k12 = -15;
var k13 = -20;
var k14 = -25;
var k15 = -30;
var k16 = -35;
var k17 = -40;

// celcijaus skales vaizdavimui
var tC1 = tempC + k1;
var tC2 = tempC + k2;
var tC3 = tempC + k3;
var tC4 = tempC + k4;
var tC5 = tempC + k5;
var tC6 = tempC + k6;
var tC7 = tempC + k7;
var tC8 = tempC + k8;
var tC9 = tempC + k9;
var tC10 = tempC + k10;
var tC11 = tempC + k11;
var tC12 = tempC + k12;
var tC13 = tempC + k13;
var tC14 = tempC + k14;
var tC15 = tempC + k15;
var tC16 = tempC + k16;
var tC17 = tempC + k17;

//farenheito skales konvertavimas
var fC1 = (tC1 * 9 / 5) + 32;
var fC2 = (tC2 * 9 / 5) + 32;
var fC3 = (tC3 * 9 / 5) + 32;
var fC4 = (tC4 * 9 / 5) + 32;
var fC5 = (tC5 * 9 / 5) + 32;
var fC6 = (tC6 * 9 / 5) + 32;
var fC7 = (tC7 * 9 / 5) + 32;
var fC8 = (tC8 * 9 / 5) + 32;
var fC9 = (tC9 * 9 / 5) + 32;
var fC10 = (tC10 * 9 / 5) + 32;
var fC11 = (tC11 * 9 / 5) + 32;
var fC12 = (tC12 * 9 / 5) + 32;
var fC13 = (tC13 * 9 / 5) + 32;
var fC14 = (tC14 * 9 / 5) + 32;
var fC15 = (tC15 * 9 / 5) + 32;
var fC16 = (tC16 * 9 / 5) + 32;
var fC17 = (tC17 * 9 / 5) + 32;

// surasti vidurines skales vidury
bool TS1 = tempC >= tC1;
bool TS2 = tempC >= tC2;
bool TS3 = tempC >= tC3;
bool TS4 = tempC >= tC4;
bool TS5 = tempC >= tC5;
bool TS6 = tempC >= tC6;
bool TS7 = tempC >= tC7;
bool TS8 = tempC >= tC8;
bool TS9 = tempC >= tC9;
bool TS10 = tempC >= tC10;
bool TS11 = tempC >= tC11;
bool TS12 = tempC >= tC12;
bool TS13 = tempC >= tC13;
bool TS14 = tempC >= tC14;
bool TS15 = tempC >= tC15;
bool TS16 = tempC >= tC16;
bool TS17 = tempC >= tC17;


//paisome termometra

Console.WriteLine($"        |--------------------|  ");
Console.WriteLine($"        |   ^F    _    ^ C   |  ");
Console.WriteLine($"        | {fC1,5} - |{(TS1).ToString().Replace("True", "#").Replace("False", " ")} | - {tC1,3} | ");
Console.WriteLine($"        | {fC2,5} - |{(TS2).ToString().Replace("True", "#").Replace("False", " ")} | - {tC2,3} | ");
Console.WriteLine($"        | {fC3,5} - |{(TS3).ToString().Replace("True", "#").Replace("False", " ")} | - {tC3,3} | ");
Console.WriteLine($"        | {fC4,5} - |{(TS4).ToString().Replace("True", "#").Replace("False", " ")} | - {tC4,3} | ");
Console.WriteLine($"        | {fC5,5} - |{(TS5).ToString().Replace("True", "#").Replace("False", " ")} | - {tC5,3} | ");
Console.WriteLine($"        | {fC6,5} - |{(TS6).ToString().Replace("True", "#").Replace("False", " ")} | - {tC6,3} | ");
Console.WriteLine($"        | {fC7,5} - |{(TS7).ToString().Replace("True", "#").Replace("False", " ")} | - {tC7,3} | ");
Console.WriteLine($"        | {fC8,5} - |{(TS8).ToString().Replace("True", "#").Replace("False", " ")} | - {tC8,3} | ");
Console.WriteLine($"        | {fC9,5} - |{(TS9).ToString().Replace("True", "#").Replace("False", " ")} | - {tC9,3} | ");
Console.WriteLine($"        | {fC10,5} - |{(TS10).ToString().Replace("True", "#").Replace("False", " ")} | - {tC10,3} | ");
Console.WriteLine($"        | {fC11,5} - |{(TS11).ToString().Replace("True", "#").Replace("False", " ")} | - {tC11,3} | ");
Console.WriteLine($"        | {fC12,5} - |{(TS12).ToString().Replace("True", "#").Replace("False", " ")} | - {tC12,3} | ");
Console.WriteLine($"        | {fC13,5} - |{(TS13).ToString().Replace("True", "#").Replace("False", " ")} | - {tC13,3} | ");
Console.WriteLine($"        | {fC14,5} - |{(TS14).ToString().Replace("True", "#").Replace("False", " ")} | - {tC14,3} | ");
Console.WriteLine($"        | {fC15,5} - |{(TS15).ToString().Replace("True", "#").Replace("False", " ")} | - {tC15,3} | ");
Console.WriteLine($"        | {fC16,5} - |{(TS16).ToString().Replace("True", "#").Replace("False", " ")} | - {tC16,3} | ");
Console.WriteLine($"        | {fC17,5} - |{(TS17).ToString().Replace("True", "#").Replace("False", " ")} | - {tC17,3} | ");
Console.WriteLine($"        |        '***`       | ");
Console.WriteLine($"        |       (*****)      | ");
Console.WriteLine($"        |        `---'       | ");
Console.WriteLine($"        |____________________| ");






// antra uzduotis


Console.WriteLine("Kelio skaiciavimo programa!");

Console.WriteLine("Iveskite atstumą Kilometrais tarp A ir B ");
var atstumasKilometrais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Iveskite greiti Km/H pirmo automobilio");
var greitisAMasinos = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Iveskite greiti Km/H pirmo automobilio");
var greitisBMasinos = Convert.ToDouble(Console.ReadLine());

var laikasNuoAIkiSusitikimo = atstumasKilometrais / (greitisAMasinos + greitisBMasinos); 
var atstumasNuoAIkiSusitikimo = laikasNuoAIkiSusitikimo * greitisAMasinos;

Console.WriteLine($"susitikimas įvyks už {atstumasNuoAIkiSusitikimo * 1000} metru");
Console.WriteLine($"susitikimas įvyks per {laikasNuoAIkiSusitikimo * 3600} sekundziu");
Console.WriteLine($"A masina nuvaziuos per {atstumasKilometrais / greitisAMasinos * 60 } minuciu");
Console.WriteLine($"B masina nuvaziuos per {atstumasKilometrais / greitisBMasinos * 60} minuciu");
Console.WriteLine($"Automobiliu tarsa {atstumasKilometrais * 95 *2} gramu ");


//paisymas A variantas 

double s0 = 0;
double segmentasVienas = atstumasKilometrais / 20; // suskaiciuoja elemento dydi
var tS = " |";

var pS1 = s0 += segmentasVienas; // sugraduoja elementus
var pS2 = s0 += segmentasVienas;
var pS3 = s0 += segmentasVienas;
var pS4 = s0 += segmentasVienas;
var pS5 = s0 += segmentasVienas;
var pS6 = s0 += segmentasVienas;
var pS7 = s0 += segmentasVienas;
var pS8 = s0 += segmentasVienas;
var pS9 = s0 += segmentasVienas;
var pS10 = s0 += segmentasVienas;
var pS11 = s0 += segmentasVienas;
var pS12 = s0 += segmentasVienas;
var pS13 = s0 += segmentasVienas;
var pS14 = s0 += segmentasVienas;
var pS15 = s0 += segmentasVienas;
var pS16 = s0 += segmentasVienas;
var pS17 = s0 += segmentasVienas;
var pS18 = s0 += segmentasVienas;
var pS19 = s0 += segmentasVienas;
var pS20 = s0 += segmentasVienas;

Console.WriteLine();    
Console.WriteLine($"Visas kelias {atstumasKilometrais} km");
Console.WriteLine($" | -------------------------------------------------------------------------------------------------------------------------------------------- | "); // hardcore piesimas
Console.WriteLine($"  0{pS1, 7}{pS2, 7}{pS3, 7}{pS4,7}{pS5,7}{pS6,7}{pS7,7}{pS8,7}{pS9,7}{pS10,7}{pS11,7}{pS12,7}{pS13,7}{pS14,7}{pS15,7}{pS16,7}{pS17,7}{pS18,7}{pS19,7}{pS20,7}"); //piesia i elementu vietas ju reiksmes
Console.WriteLine($"  |{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}{tS,7}"); // paiso tarpus
Console.WriteLine($" _A{((pS1 >= atstumasNuoAIkiSusitikimo)&&(pS1 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V___|").Replace("False", "______|"),7}" +
 $"{((pS2 >= atstumasNuoAIkiSusitikimo) && (pS2 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS3 >= atstumasNuoAIkiSusitikimo) && (pS3 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS4 >= atstumasNuoAIkiSusitikimo) && (pS4 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS5 >= atstumasNuoAIkiSusitikimo) && (pS5 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS6 >= atstumasNuoAIkiSusitikimo) && (pS6 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS7 >= atstumasNuoAIkiSusitikimo) && (pS7 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS8 >= atstumasNuoAIkiSusitikimo) && (pS8 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS9 >= atstumasNuoAIkiSusitikimo) && (pS9 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS10 >= atstumasNuoAIkiSusitikimo) && (pS10 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS11 >= atstumasNuoAIkiSusitikimo) && (pS11 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS12 >= atstumasNuoAIkiSusitikimo) && (pS12 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS13 >= atstumasNuoAIkiSusitikimo) && (pS13 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS14 >= atstumasNuoAIkiSusitikimo) && (pS14 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS15 >= atstumasNuoAIkiSusitikimo) && (pS15 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS16 >= atstumasNuoAIkiSusitikimo) && (pS16 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS17 >= atstumasNuoAIkiSusitikimo) && (pS17 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS18 >= atstumasNuoAIkiSusitikimo) && (pS18 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS19 >= atstumasNuoAIkiSusitikimo) && (pS19 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______|"),7}" +
 $"{((pS20 >= atstumasNuoAIkiSusitikimo) && (pS20 <= atstumasNuoAIkiSusitikimo)).ToString().Replace("True", "___V__|").Replace("False", "______B_"),7}");
// susitikimo piesimas
Console.WriteLine($" |" +
 $"{((pS1 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS2 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS3 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS4 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS5 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS6 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS7 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS8 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS9 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS10 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS11 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS12 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS13 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS14 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS15 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS16 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS17 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS18 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS19 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}" +
 $"{((pS20 <= atstumasNuoAIkiSusitikimo) ).ToString().Replace("True", "_______").Replace("False", "")}|");


Console.WriteLine();
Console.WriteLine($"  susitikimo vieta {atstumasNuoAIkiSusitikimo} km ");
Console.WriteLine($"  susitikimo laikas po {laikasNuoAIkiSusitikimo} val. ");
double aLaikas = atstumasKilometrais / greitisAMasinos;
double bLaikas = atstumasKilometrais / greitisBMasinos;
string aKelias = new string('>', (int)aLaikas * 60);
string bKelias = new string('<', (int)bLaikas * 60);
Console.WriteLine($"| {aKelias} A Auto važiuos {atstumasKilometrais / greitisAMasinos * 60} min >>> | "); // pagal laika piesia atstuma
Console.WriteLine($"| {bKelias} B Auto važiuos {atstumasKilometrais / greitisBMasinos * 60} min <<< | "); // pagal laika piesia kita atstuma



//Alternatyva B paisymo 
Console.WriteLine();
Console.WriteLine("Alternatyvus piesinys");
double segmentas = atstumasKilometrais / 20;
double segmentassusitikimo = atstumasNuoAIkiSusitikimo / segmentas;
double atkarpa = 0;
const int tar = 5; //elemento dydzio kintamasis
string Susitikimas = "_V__|";
string nesusitikimas = "____|";
int i = 0;

string piestiKelia = new string('-', (int)atstumasKilometrais); // kelio piesinis priklauso nuo km 
Console.WriteLine($"|{piestiKelia}| ");
Console.WriteLine($"{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}");
Console.WriteLine($"{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}");
string skelias = new string('-', (int)atstumasNuoAIkiSusitikimo); // piesia susitikimo kilometrus
Console.WriteLine();
Console.WriteLine($"|{skelias}|");

// geriausiai vaizduoja 100 km 
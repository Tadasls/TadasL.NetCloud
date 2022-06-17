// See https://aka.ms/new-console-template for more information
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
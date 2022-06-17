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


/*
   - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
    A) PARODYTI VISO KELIO ILGĮ KM
    B) PARODYTI SEGMENTO ILGĮ KM
    C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
    D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
    REZULTATAS GALI ARTODYTI TAIP:
   viso 100 km
   //paisymas A variantas 

*/


double s0 = 0;
double segmentasVienas = atstumasKilometrais / 20;

Console.WriteLine($" | --------------------------------------------------------------------------------------------------------------------------------------------| ");
Console.WriteLine($" kelio gradacija {s0+=segmentasVienas}, {s0+= segmentasVienas}, {s0+= segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas},{s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas}, {s0 += segmentasVienas} ");


Console.WriteLine($"     |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      | ");


Console.WriteLine($"     |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      | ");


// A______ | ______ | ______ | ______ | ___V___ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______B_


 // | -------------------------------|
Console.WriteLine($"  susitikimo vieta {atstumasNuoAIkiSusitikimo} km ");
Console.WriteLine($"   susitikimo laikas po {laikasNuoAIkiSusitikimo} val. ");
Console.WriteLine($"| >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> A Auto važiuos {atstumasKilometrais / greitisAMasinos * 60 } min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>| ");
Console.WriteLine($" |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<  B Auto važiuos {atstumasKilometrais / greitisBMasinos * 60}  min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< | ");












//Alternatyva B

double segmentas = atstumasKilometrais / 20;
double segmentassusitikimo = atstumasNuoAIkiSusitikimo / segmentas;
double atkarpa = 0;
const int tar = 6;

string piestiKelius = new string('V', 100); // cool funkcija 

string Susitikimas = "__V__|";
string nesusitikimas = "_____|";
int i = 0;
Console.WriteLine($"{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}");
Console.WriteLine();
Console.WriteLine($"{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}");


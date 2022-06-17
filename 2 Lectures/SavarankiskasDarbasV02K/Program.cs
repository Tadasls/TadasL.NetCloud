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

/
/*
   - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
    A) PARODYTI VISO KELIO ILGĮ KM
    B) PARODYTI SEGMENTO ILGĮ KM
    C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
    D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
    REZULTATAS GALI ARTODYTI TAIP:
   viso 100 km
   
    //paisymas

 | --------------------------------------------------------------------------------------------------------------------------------------------|
 0      5     10     15     20      25     30     35     40     45     50     55     60     65     70     75     80     85     90     95    100
 |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
 A______ | ______ | ______ | ______ | ___V___ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______B_
 | -------------------------------|
   susitikimo vieta 23,1 km
   susitikimo laikas po 0,87 val.
 | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   200 min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|
 |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   60 min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< |

*/






/*
var kelias = 100;
var susitiks = 27;
int segmentas = kelias / 20;
int segmentassusitikimo = susitiks / segmentas;
int atkarpa = 0;
const int tar = 6;
string Susitikimas = "__V__|";
string nesusitikimas = "_____|";
string Testas = new string('V', 100);
int i = 0;
Console.WriteLine($"{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}{atkarpa += segmentas,tar}");
Console.WriteLine($"{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}{(i++ == segmentassusitikimo).ToString().Replace("True", Susitikimas).Replace("False", nesusitikimas)}");

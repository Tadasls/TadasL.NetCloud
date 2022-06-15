// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kelio skaiciavimas!");

//skaiciavimai


//PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H). 
//VIENA TRANSPORTO PRIEMONĖS PRADEDA VAŽIUOTI IŠ A, KITA IŠ B.STARTUOJA VIENU METU.
// - PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
//  - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS. 
//  - PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.
//  - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.

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

//var laikasPasiektiGalaAmasinai = atstumasKilometrais / greitisAMasinos;
//var laikasPasiektiGalaAmasinai = atstumasKilometrais / greitisBMasinos;
//var tarsaAutomobiliu = atstumasKilometrais * 95 * 2; 



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
_A______ | ______ | ______ | ______ | ___V___ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______ | ______B_
 | -------------------------------|
   susitikimo vieta 23,1 km
   susitikimo laikas po 0,87 val.
 | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   200 min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|
 |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   60 min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< |

*/










// atstumas skaiciuojamas laikui suskaiciuoti  t=s/(u1+u2) s - atstumas, u1 ir u2 - greitis, t - laikas
// atstumas S / padalinti is greiciu sumos 
//tada laika padauginti is greicio ar padalinti kad gauti kelia. 
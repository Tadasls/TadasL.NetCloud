// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tado Antrieji Namu darbai  - Registracijos Forma!");

var status = ""; // isivedu kintamaji
DateTime userBirthDate = DateTime.Today;
bool hasBirt = false; 

Console.WriteLine("Įveskite Vardą ir Pavardę");
var userName = Console.ReadLine(); //ivedam varda ir pavarde kartu
Console.WriteLine("Įveskite asmens Kodą 11 simbolių");
var userCode = Console.ReadLine(); //ivedamas asmens kodas
Console.WriteLine("Įveskite amžių metais  ");
string userAge = Console.ReadLine();   //ivedamas amzius
Console.WriteLine("Įveskite Gimimo data");
var ivedamaData = Console.ReadLine(); //ivedama gimimo data

if (ivedamaData != "")
{
 userBirthDate = DateTime.Parse(ivedamaData); //ivedama gimimo data
    hasBirt = true;
}
   bool hasAge = (userAge.Length > 0)? true:false;

// tikriname ar vyras ar moteris ir paraso
var firstUserCodeChar = userCode.Substring(0,1);
string lytis;
if (firstUserCodeChar == "1" || firstUserCodeChar == "3" || firstUserCodeChar == "5")
{ lytis = "Vyras"; }
else {
    lytis = "Moteris";
        };

//extra uzduotis tikriname asmens koda // pvz 33309240064  
// pasidaliname ivesta asmens koda i tekstinis skaitmenis 
string A = userCode.Substring(0, 1);
string B = userCode.Substring(1, 1);
string C = userCode.Substring(2, 1);
string D = userCode.Substring(3, 1);
string E = userCode.Substring(4, 1);
string F = userCode.Substring(5, 1);
string G = userCode.Substring(6, 1);
string H = userCode.Substring(7, 1);
string I = userCode.Substring(8, 1);
string J = userCode.Substring(9, 1);
string K = userCode.Substring(10, 1);

//pasikeiciam tekstinius skaitmenis i skaicius
var vA = Convert.ToInt32(A);
var vB = Convert.ToInt32(B);
var vC = Convert.ToInt32(C);
var vD = Convert.ToInt32(D);
var vE = Convert.ToInt32(E);
var vF = Convert.ToInt32(F);
var vG = Convert.ToInt32(G);
var vH = Convert.ToInt32(H);
var vI = Convert.ToInt32(I);
var vJ = Convert.ToInt32(J);
var vK = Convert.ToInt32(K);

int sumaKodo = vA * 1 + vB * 2 + vC * 3 + vD * 4 + vE * 5 + vF * 6 + vG * 7 + vH * 8 + vI * 9 + vJ * 1;
int check1; 

if (sumaKodo % 11 != 10)
{
    check1 = sumaKodo % 11;
}
else
{
    var check2 = (vA * 3 + vB * 4 + vC * 5 + vD * 6 + vE * 7 + vF * 8 + vG * 9 + vH * 1 + vI * 2 + vJ * 3) % 11;
    check1 = (check2 != 10) ? check2 : 0;
}

if (vK == check1)
{
Console.WriteLine($" asm kodo {userCode} kontrolinis skaicius yra {check1}");
    var userCodeStatus = userCode;
}
else if (userCode.Length != 11)
{
Console.WriteLine("Kodas per trumpas");
    var userCodeStatus = "Kodas per trumpas";
}
    else
{
   Console.WriteLine("kodas neteisingas");
   var userCodeStatus = "kodas neteisingas";
} 
 
// pirmas patikrinimas ivesta amziu lygina su gimimo data
// is kodo paimame metus menesy diena
var birthYear = userCode.Substring(1, 2);
var birthMonth = userCode.Substring(3, 2);
var birthDay = userCode.Substring(5, 2);
DateTime now = DateTime.Today;
//is Gimimo metu padaromas amzius
if (hasBirt&&hasAge) 
{
    DateTime gimimoMetai = userBirthDate;
    
    int age = now.Year - gimimoMetai.Year;
    if (now.Month < gimimoMetai.Month || (now.Month == gimimoMetai.Month
    && now.Day < gimimoMetai.Day))
        age--;

    if (Convert.ToInt32(userAge) == age)
        status = " amžius patikimas";
    else
        status = " amžius pameluotas";
//antras patikrinimas ivesta gimimo data lygina su asm kodo metais
    if (userBirthDate.Year.ToString().Substring(2, 2) == birthYear)
        status = " amžius patikimas";
    else
        status = " amžius pameluotas";
// trecias patikrinimas visu triju

    var ivestasAmzius = userAge.Substring(0, 2);
    int skAmzius = (now.Year - Convert.ToInt32(userAge) - 1);
    var vartAmzius = Convert.ToString(skAmzius);

    if ((vartAmzius == userBirthDate.Year.ToString() && birthYear == userBirthDate.Year.ToString().Substring(2, 2) && (hasBirt && hasAge)))
        status = " amžius tikras";
    if ((vartAmzius == userBirthDate.Year.ToString() && birthYear != userBirthDate.Year.ToString().Substring(2, 2) && (hasBirt && hasAge))) 
        status = " amžius nepatikimas";
    if ((vartAmzius != userBirthDate.Year.ToString() && birthYear == userBirthDate.Year.ToString().Substring(2, 2) && (hasBirt && hasAge))) 
        status = " amžius pameluotas";
}

if (!hasBirt && !hasAge)
{ status = " patikimumui trūksta duomenų";}


// lenteles piesinys

Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓ {DateTime.Now.ToShortDateString(),-20}   ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ " );
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Vardas, Pavarde      ▓ {userName, -34} ▓ ");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Lytis                ▓ {lytis, -34} ▓ ");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Asmens Kodas         ▓ {userCode, -35}▓ ");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amzius               ▓ {userAge, -34} ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Gimimo Data          ▓ {userBirthDate.ToString("yyyy-MM-dd"), -34} ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amziaus patikimumas  ▓ {status,-34} ▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
// programos pabaiga ▓ 

 
  // destytojo versija


    Console.WriteLine("Hello, Amziaus melagis!");
    var vardas = "Vardenis Pavardenis";
    var kodas = "44012029286";
    var amzius = "82";
    var gimData = "1940-12-03";

    var isAsmKodas = kodas.Length == 11 && long.TryParse(kodas, out _);
    var lytis1 = !isAsmKodas ? "N/D" : int.Parse(kodas.Substring(0, 1)) % 2 == 0 ? "Moteris" : "Vyras";

    var isAmzius = int.TryParse(amzius, out int amziusInt) && amziusInt >= 0;
    var isGimData = DateTime.TryParse(gimData, out DateTime gimDataDate) && gimDataDate <= DateTime.Today;

    if (!isAmzius) amzius = "N/G";
    if (!isGimData) gimData = "N/G";

    var patikimumas = "patikimumui trūksta duomenų";
    if ((isAmzius || isGimData) && isAsmKodas)
    {
        var kodoMetai = (kodas.Substring(0, 1) switch
        {
            "1" or "2" => 18 + kodas.Substring(1, 2),
            "3" or "4" => 19 + kodas.Substring(1, 2),
            "5" or "6" => 20 + kodas.Substring(1, 2),
            _ => 21 + kodas.Substring(1, 2),
        }) + $"-{kodas.Substring(3, 2)}-{kodas.Substring(5, 2)}";
        var gimDataPagalAsmKodaDate = DateTime.Parse(kodoMetai);
        var amziusPagalAsmKoda = (int)((DateTime.Today - gimDataPagalAsmKodaDate).TotalDays / 365.25);
        var isGimDataPatikima = gimDataPagalAsmKodaDate == gimDataDate && isGimData;
        var isDataPagalAmziuPatikima = amziusInt == amziusPagalAsmKoda && isAmzius;

        if (isGimDataPatikima && isDataPagalAmziuPatikima)
            patikimumas = "amzius tikras";
        else if ((isGimDataPatikima || isDataPagalAmziuPatikima) && isAmzius && isGimData)
            patikimumas = "amzius nepatikimas";
        else if (isGimDataPatikima || isDataPagalAmziuPatikima)
            patikimumas = "amzius patikimas";
        else
            patikimumas = "amzius pameluotas";
    }


    var output =
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {DateTime.Today.ToShortDateString()}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓     Vardas, pavardė ▓ {vardas,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓               Lytis ▓ {lytis1,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓        Asmens kodas ▓ {kodas,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓              Amžius ▓ {amzius,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓         Gimimo data ▓ {gimData,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓ Amžiaus patikimumas ▓ {patikimumas,-35} ▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n" +
     $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\n";

    Console.WriteLine(output);
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tado Antrieji Namu darbai  - Registracijos Forma!");

var status = "viskas ok"; // isivedu kintamaji

Console.WriteLine("Įveskite Vardą ir Pavardę");
var userName = Console.ReadLine(); //ivedam varda ir pavarde kartu
Console.WriteLine("Įveskite asmens Kodą 11 simbolių");
var userCode = Console.ReadLine(); //ivedamas asmens kodas
Console.WriteLine("Įveskite amžių metais  ");
var userAge = Console.ReadLine();   //ivedamas amzius
Console.WriteLine("Įveskite Gimimo data");
var userBirthDate = DateTime.Parse(Console.ReadLine()); //ivedama gimimo data


// tikriname ar vyras ar moteris ir paraso
var firstUserCodeChar = userCode.Substring(0,1);
string lytis;
if (firstUserCodeChar == "1" || firstUserCodeChar == "3" || firstUserCodeChar == "5")
{ lytis = "Vyras"; }
else {
    lytis = "Moteris";
        };

// is kodo paimame metus menesy diena
var userBirthYear = userCode.Substring(1, 2);
var userBirthMonth = userCode.Substring(3, 2);
var userBirthDay = userCode.Substring(5, 2);

//  Console.WriteLine($"kodo dalis metai {userBirthYear} menuo {userBirthMonth} diena {userBirthDay}  ");

//tikrina asmens kodo ilgi
bool arGerasUserCode = userCode.Length == 11;
// Console.WriteLine($" patikrina koda 11 {arGerasUserCode}");

//extra uzduotis tikriname asmens koda
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
    var temp = (vA * 3 + vB * 4 + vC * 5 + vD * 6 + vE * 7 + vF * 8 + vG * 9 + vH * 1 + vI * 2 + vJ * 3) % 11;
    check1 = (temp != 10) ? temp : 0;
}

Console.WriteLine($" kontrolinis skaicius yra {check1}");


/*   jei prireiktu pilnos datos.. 
string pilnaData;
if (userCode[0] == 1 || userCode[0] == 2)
{
    pilnaData = "18" + userBirthDate;
}
else if (userCode[0] == 3 || userCode[0] == 4)
{
    pilnaData = "19" + userBirthDate;
}
else if (userCode[0] == 5 || userCode[0] == 6)
{
    pilnaData = "20" + userBirthDate;
}
else Console.WriteLine($"pilna data nesigavo padaryti is {userCode[0]}");
*/


// pirmas patikrinimas ivesta amziu lygina su gimimo data
        //is Gimimo metu padaromas amzius

DateTime gimimoMetai = userBirthDate;
DateTime now = DateTime.Today;
int age = now.Year - gimimoMetai.Year;
if (now.Month < gimimoMetai.Month || (now.Month == gimimoMetai.Month
&& now.Day < gimimoMetai.Day))
    age--;

if (Convert.ToInt32(userAge) == age)
{
    Console.WriteLine("amžius patikimas");
    status = " 1 amžius patikimas";
}
else
{
    Console.WriteLine("amžius pameluotas");
    status = " 2 amžius pameluotas";
}

//antras patikrinimas ivesta gimimo data lygina su asm kodo metais
if (userBirthDate.Year.ToString().Substring(2, 2) == userBirthYear)
{
    Console.WriteLine("amžius patikimas");
    status = " 3 amžius patikimas";
}
else
{
    Console.WriteLine("amžius pameluotas");
    status = " 4 amžius pameluotas";
}

// trecias patikrinimas visu triju
if (userAge == userBirthDate.Year.ToString().Substring(2, 2) &&
userBirthYear == userBirthDate.Year.ToString().Substring(2, 2))
{
    Console.WriteLine("amžius tikras");
    status = " 5 amžius tikras";
}

else if (userAge == userBirthDate.Year.ToString().Substring(2, 2) ||
userBirthYear == userBirthDate.Year.ToString().Substring(2, 2))
{
    Console.WriteLine("amžius nepatikimas");
    status = " 6 amžius nepatikimas";
}
else
{
    Console.WriteLine("amžius pameluotas");
    status = " 7 amžius pameluotas";
}

if (userBirthDate == null && userAge == null)
{
    Console.WriteLine("patikimumui trūksta duomenų");
    status = " 8 patikimumui trūksta duomenų";
}


Console.WriteLine($" ATASKAITA APIE ASMENĮ ");
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine();
Console.WriteLine($" Vardas, Pavarde {userName} ");
Console.WriteLine();
Console.WriteLine($" Lytis {lytis} ");
Console.WriteLine();
Console.WriteLine($" Asmens Kodas {userCode} ");
Console.WriteLine();
Console.WriteLine($" Amzius {userAge} ");
Console.WriteLine();
Console.WriteLine($" Gimimo Data {userBirthDate.ToString("yyyy-MM-dd")} ");
Console.WriteLine();
Console.WriteLine($" Amziaus patikimumas - \"{status}");

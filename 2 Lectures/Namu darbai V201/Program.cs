// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tado Antrieji Namu darbai  - Registracijos Forma!");


Console.WriteLine("Įveskite Vardą ir Pavardę");
var userName = Console.ReadLine();
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
     lytis = "Vyras";
else lytis = "Moteris";

// is kodo paimame metus menesy diena
var userBirthYear = userCode.Substring(1, 2);
var userBirthMonth = userCode.Substring(3, 2);
var userBirthDay = userCode.Substring(5, 2);
 Console.WriteLine($"kodo dalis metai {userBirthYear} menuo {userBirthMonth} diena {userBirthDay}  ");

//tikrina asmens kodo ilgi
bool arGerasUserCode = userCode.Length == 11;
Console.WriteLine($" patikrina koda 11 {arGerasUserCode}");


/*
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

//pirmas patikrinimas ivesta amziu lygina su gimimo data
        //is Gimimo metu padaromas amzius 
DateTime gimimoMetai = userBirthDate;
DateTime now = DateTime.Today;
int age = now.Year - gimimoMetai.Year;
if (now.Month < gimimoMetai.Month || (now.Month == gimimoMetai.Month && now.Day < gimimoMetai.Day))
    age--;
if (Convert.ToInt32(userAge) == age)
    Console.WriteLine("amžius patikimas");
else Console.WriteLine("amžius pameluotas");

//Console.WriteLine($"mano amzius yra {age}");
//Console.WriteLine(Gimimo.ToShortDateString());
//Console.WriteLine(now.ToShortDateString());

//antras patikrinimas ivesta gimimo data lygina su asm kodo metais
if (userBirthDate.Year.ToString().Substring(2,2) == userBirthYear)
    Console.WriteLine("amžius patikimas");
else Console.WriteLine("amžius pameluotas");


// trecias patikrinimas visu triju

if(userAge == userBirthDate.Year.ToString().Substring(2, 2)  && userBirthYear == userBirthDate.Year.ToString().Substring(2, 2))
    Console.WriteLine("amžius tikras");
else if (userAge == userBirthDate.Year.ToString().Substring(2, 2) || userBirthYear == userBirthDate.Year.ToString().Substring(2, 2))
        Console.WriteLine("amžius nepatikimas");
else Console.WriteLine("amžius pameluotas");

if (userBirthDate == null && userAge == null)
    Console.WriteLine("patikimumui trūksta duomenų");


Console.WriteLine($" ATASKAITA APIE ASMENĮ ");
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine();
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
Console.WriteLine($" Amziaus patikimumas DAR NEVEIKIA ");

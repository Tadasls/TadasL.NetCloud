// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, savarankiskas Darbas!");



Console.WriteLine("įvesti 1 skaičių - temperatūrą pagal Celsijų.");

var tempC = Convert.ToDouble(Console.ReadLine());
var tempF = (tempC * 9 / 5 ) + 32;
var tempK = tempC + 273.16;

var tempCPerskIsF = (tempF - 32) / 1.8;
var tempCPerskIsK = tempK - 273.16;
var tempKPerskIsF = (((tempF - 32) / 1.8) + 273.16);

bool patikrinimas1 = tempC == tempCPerskIsF;
bool patikrinimas2 = tempC == tempCPerskIsK;
bool patikrinimas3 = tempKPerskIsF == tempK;

Console.WriteLine($" Temp Farenfeitais  - {tempF}"); //išveskite į ekraną temperatūrą pagal farenheitą.
Console.WriteLine($" Temp Kelvinais  - {tempK}"); //išveskite į ekraną temperatūrą pagal kelviną.

Console.WriteLine($" Temp celsijais  - {tempCPerskIsF}");
Console.WriteLine($" Temp celsijais  - {tempCPerskIsK}"); 
Console.WriteLine($" Temp Kelvinais - {tempKPerskIsF}"); 

Console.WriteLine($" ar sutapima konvertuota C is F ? {patikrinimas1}"); //patikrinimas 1
Console.WriteLine($" ar sutapima konvertuota C is K ? {patikrinimas2}"); //patikrinimas 2
Console.WriteLine($" ar sutapima konvertuota C is K ? {patikrinimas3}"); //patikrinimas 3

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

bool TS1 = tempC >= k1 + tempC;
bool TS2 = tempC >= k2 + tempC;
bool TS3 = tempC >= k3 + tempC;
bool TS4 = tempC >= k4 + tempC;
bool TS5 = tempC >= k5 + tempC;
bool TS6 = tempC >= k6 + tempC;
bool TS7 = tempC >= k7 + tempC;
bool TS8 = tempC >= k8 + tempC;
bool TS9 = tempC >= k9 + tempC;
bool TS10 = tempC >= k10 + tempC;
bool TS11 = tempC >= k11 + tempC;
bool TS12 = tempC >= k12 + tempC;
bool TS13 = tempC >= k13 + tempC;
bool TS14 = tempC >= k14 + tempC;
bool TS15 = tempC >= k15 + tempC;
bool TS16 = tempC >= k16 + tempC;
bool TS17 = tempC >= k17 + tempC;


//paisome termometra

Console.WriteLine($"        |--------------------|  ");
Console.WriteLine($"        |   ^F     _ ^ C     |  ");
Console.WriteLine($"        | {fC1}  - |{(TS1).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC1}  | ");
Console.WriteLine($"        | {fC2}  - |{(TS2).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC2}  | ");
Console.WriteLine($"        | {fC3}  - |{(TS3).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC3}  | ");
Console.WriteLine($"        | {fC4}  - |{(TS4).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC4}  | ");
Console.WriteLine($"        | {fC5}  - |{(TS5).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC5}  | ");
Console.WriteLine($"        | {fC6}  - |{(TS6).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC6}  | ");
Console.WriteLine($"        | {fC7}  - |{(TS7).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC7}  | ");
Console.WriteLine($"        | {fC8}  - |{(TS8).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC8}  | ");
Console.WriteLine($"        | {fC9}  - |{(TS9).ToString().Replace("True", "#").Replace("False", " ")}  | - {tC9}  | ");
Console.WriteLine($"        | {fC10} - |{(TS10).ToString().Replace("True", "#").Replace("False", " ")} | - {tC10} | ");
Console.WriteLine($"        | {fC11} - |{(TS11).ToString().Replace("True", "#").Replace("False", " ")} | - {tC11} | ");
Console.WriteLine($"        | {fC12} - |{(TS12).ToString().Replace("True", "#").Replace("False", " ")} | - {tC12} | ");
Console.WriteLine($"        | {fC13} - |{(TS13).ToString().Replace("True", "#").Replace("False", " ")} | - {tC13} | ");
Console.WriteLine($"        | {fC14} - |{(TS14).ToString().Replace("True", "#").Replace("False", " ")} | - {tC14} | ");
Console.WriteLine($"        | {fC15} - |{(TS15).ToString().Replace("True", "#").Replace("False", " ")} | - {tC15} | ");
Console.WriteLine($"        | {fC16} - |{(TS16).ToString().Replace("True", "#").Replace("False", " ")} | - {tC16} | ");
Console.WriteLine($"        | {fC17} - |{(TS17).ToString().Replace("True", "#").Replace("False", " ")} | - {tC17} | ");
Console.WriteLine($"        |        '***`          | ");
Console.WriteLine($"        |       (*****)         | ");
Console.WriteLine($"        |        `---'          | ");
Console.WriteLine($"        |  ____________________ | ");







/*

Console.WriteLine();
var a = 1233154;
 Console.WriteLine($" | ---{a,-6}--- |"  );
Console.WriteLine(" | ---{0,-6}--- |", a);
Console.WriteLine($"  | ---------    |"   );

*/
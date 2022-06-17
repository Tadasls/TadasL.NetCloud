// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, savarankiskas Tado Darbas 001 !");

Console.WriteLine("įveskite - temperatūrą Celsijais.");

var tempC = Convert.ToDouble(Console.ReadLine()); // nuskaito ivedima
var tempF = (tempC * 9 / 5 ) + 32;
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







/*

var a = 1233154;
 Console.WriteLine($" | ---{a,-6}--- |"  );
Console.WriteLine(" | ---{0,-6}--- |", a);
Console.WriteLine($"  | ---------    |"   );

*/
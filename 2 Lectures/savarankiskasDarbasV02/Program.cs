// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, savarankiskas Darbas!");



Console.WriteLine("įvesti 1 skaičių - temperatūrą pagal Celsijų.");

var tempC = Convert.ToDouble(Console.ReadLine());
var tempF = tempC + 32;
var tempK = tempC + 273.16;

var tempCPerskIsF = tempF - 32;
var tempCPerskIsK = tempK - 273.16;
var tempKPerskIsF = ((tempF - 32) + 273.16);

bool patikrinimas1 = tempC == tempCPerskIsF;
bool patikrinimas2 = tempC == tempCPerskIsK;
bool patikrinimas3 = tempKPerskIsF == tempK;

Console.WriteLine($" Temp Farenfeitais {tempF}"); //išveskite į ekraną temperatūrą pagal farenheitą.
Console.WriteLine($" Temp Kelvinais {tempK}"); //išveskite į ekraną temperatūrą pagal kelviną.

Console.WriteLine($" Temp celsijais {tempCPerskIsF}");
Console.WriteLine($" Temp celsijais {tempCPerskIsK}"); 
Console.WriteLine($" Temp Kelvinais {tempKPerskIsF}"); 

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

var fC1 = tC1 + 32;
var fC2 = tC2 + 32;
var fC3 = tC3 + 32;
var fC4 = tC4 + 32;
var fC5 = tC5 + 32; 
var fC6 = tC6 + 32;
var fC7 = tC7 + 32;
var fC8 = tC8 + 32;
var fC9 = tC9 + 32;
var fC10 = tC10 + 32;
var fC11 = tC11 + 32;
var fC12 = tC12 + 32;
var fC13 = tC13 + 32;
var fC14 = tC14 + 32;
var fC15 = tC15 + 32;
var fC16 = tC16 + 32;
var fC17 = tC17 + 32;


//paisome termometra

Console.WriteLine($"        |               --------------------|  ");
Console.WriteLine($"        |             ^F     _ ^ C |      ");
Console.WriteLine($"        | {fC1} - |{tempC >= k1} | - {tC1}  | ");
Console.WriteLine($"        | {fC2} - |{tempC >= k2} | - {tC2}  | ");
Console.WriteLine($"        | {fC3} - |{tempC >= k3} | - {tC3}  | ");
Console.WriteLine($"        | {fC4} - |{tempC >= k4} | - {tC4}  | ");
Console.WriteLine($"        | {fC5} - |{tempC >= k5} | - {tC5}  | ");
Console.WriteLine($"        | {fC6} - |{tempC >= k6} | - {tC6}  | ");
Console.WriteLine($"        | {fC7} - |{tempC >= k7} | - {tC7}  | ");
Console.WriteLine($"        | {fC8} - |{tempC >= k8}  | - {tC8}  | ");
Console.WriteLine($"        | {fC9} - |{tempC >= k9}  | - {tC9}  | ");
Console.WriteLine($"        | {fC10} - |{tempC >= k10} | - {tC10} | ");
Console.WriteLine($"        | {fC11} - |{tempC >= k11}| - {tC11} | ");
Console.WriteLine($"        | {fC12} - |{tempC >= k12}| - {tC12} | ");
Console.WriteLine($"        | {fC13} - |{tempC >= k13}| - {tC13} | ");
Console.WriteLine($"        | {fC14} - |{tempC >= k14}| - {tC14} | ");
Console.WriteLine($"        | {fC15} - |{tempC >= k15}| - {tC15} | ");
Console.WriteLine($"        | {fC16} - |{tempC >= k16}| - {tC16} | ");
Console.WriteLine($"        | {fC17} - |{tempC >= k17}| - {tC17} | ");
Console.WriteLine($"        |                     '***`          | ");
Console.WriteLine($"        |                    (*****)         | ");
Console.WriteLine($"        |                     `---'          | ");
Console.WriteLine($"        |               ____________________ | ");

var TS = tempC >= k1;
var TS1 = TS.ToString().Replace("true", "1").Replace("false", "#2");
Console.WriteLine($" {TS1}, {TS}");


/*
       
     b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
        <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
        if naudoti negalima, ternary operator (?) naudoti negalima. rezultatas gali atrodyti taip:
                            |--------------------|
                            |   ^F     _    ^C   |
                            |  100  - | | -  40  |
                            |   95  - | | -  35  |
                            |   90  - | | -  30  |
                            |   80  - | | -  25  |
                            |   70  - | | -  20  |
                            |   60  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   40  - |#| -   5  |
                            |   30  - |#| -   0  |
                            |   20  - |#| -  -5  |
                            |   10  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |    0  - |#| - -20  |
                            |  -10  - |#| - -25  |
                            |  -20  - |#| - -30  |
                            |  -30  - |#| - -35  |
                            |  -40  - |#| - -40  |
                            |        '***`       |
                            |       (*****)      |
                            |        `---'       |
                            |____________________|
 */
// See https://aka.ms/new-console-template for more information
Console.WriteLine("&& (AND) , || (OR) , ! (NOT), ^ (XOR) ");


Console.WriteLine("Neigimas ! NOT operatorius");
bool tiesa = true;
bool melas = !tiesa;
Console.WriteLine($"Tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");
Console.WriteLine($"!melas = {melas}");

Console.WriteLine();
Console.WriteLine("AND &&  operatorius"); // tik kai abu teigimi tada true

Console.WriteLine($" tiesa AND Tiesa  {tiesa && tiesa} ");
Console.WriteLine($" tiesa AND melas  {tiesa && melas} ");
Console.WriteLine($" melas AND Tiesa  {melas && tiesa} ");
Console.WriteLine($" melas AND melas  {melas && melas} ");

Console.WriteLine();
Console.WriteLine("OR ||  operatorius"); 

Console.WriteLine($" tiesa OR Tiesa  {tiesa || tiesa} ");
Console.WriteLine($" tiesa OR melas  {tiesa || melas} ");
Console.WriteLine($" melas OR Tiesa  {melas || tiesa} ");
Console.WriteLine($" melas OR melas  {melas || melas} ");


Console.WriteLine();
Console.WriteLine("XOR ^  operatorius"); // sutampancios false jei sutampa tada true

Console.WriteLine($" tiesa XOR Tiesa  {tiesa ^ tiesa} ");
Console.WriteLine($" tiesa XOR melas  {tiesa ^ melas} ");
Console.WriteLine($" melas XOR Tiesa  {melas ^ tiesa} ");
Console.WriteLine($" melas XOR melas  {melas ^ melas} ");

Console.WriteLine();
Console.WriteLine("NAND  ! && operatorius"); // neigimas and operatoriui

Console.WriteLine($" tiesa NAND Tiesa  {!(tiesa && tiesa)} ");
Console.WriteLine($" tiesa NAND melas  {!(tiesa && melas)} ");
Console.WriteLine($" melas NAND Tiesa  {!(melas && tiesa)} ");
Console.WriteLine($" melas NAND melas  {!(melas && melas)} ");
Console.WriteLine($" melas NAND melas  {!melas && !melas} "); // atskirai neigiant 


Console.WriteLine();
Console.WriteLine("NOR ! OR  operatorius");

Console.WriteLine($" tiesa NOR Tiesa  {!(tiesa || tiesa)} ");
Console.WriteLine($" tiesa NOR melas  {!(tiesa || melas)} ");
Console.WriteLine($" melas NOR Tiesa  {!(melas || tiesa)} ");
Console.WriteLine($" melas NOR melas  {!(melas || melas)} ");


Console.WriteLine();
Console.WriteLine("NXOR ^  operatorius"); // priesingas XOR

Console.WriteLine($" tiesa NXOR Tiesa  {!(tiesa ^ tiesa)} ");
Console.WriteLine($" tiesa NXOR melas  {!(tiesa ^ melas)} ");
Console.WriteLine($" melas NXOR Tiesa  {!(melas ^ tiesa)} ");
Console.WriteLine($" melas NXOR melas  {!(melas ^ melas)} ");

// operacijas daro nuosekliai pirmus dviejus, tada su treciu tada su ketvirtu ir t.t.t

Console.WriteLine($" melas OR tiesa OR melas AND Tiesa  {melas || tiesa ||(melas && tiesa)} ");

int a = 5;
int b = 5;
int c = 6;

bool s = a >= b && a > c;   // bus reikalingas 2 savarankiskosuzd sprendimui

Console.WriteLine(s);


//uzdavinys1

Console.WriteLine($"Iveskite 2 skaicius  ");
var a1 = Convert.ToInt32(Console.ReadLine());
var b1 = Convert.ToInt32(Console.ReadLine());
bool ats = a1 == b1;
Console.WriteLine($" atsakymas ar A lygus B = {ats} ");

//uzdavinys2
Console.WriteLine($"Iveskite 2 skaicius  ");
var a2 = Convert.ToInt32(Console.ReadLine());
var b2 = Convert.ToInt32(Console.ReadLine());

bool ra2 = a2 % 2 == 0 ; // dalina ir tikrinam ar liekana nulis
bool rb2 = b2 % 2 == 0;
bool r = ra2 && rb2; // tikrina ar abieju liekanos yra nulines

Console.WriteLine($" atsakymas ar skaiciai abu lyginiai  = {r} ");



/*/
Uzdavinio salyga:

kanalas A __--- ___--- ___--- ___--- ___
kanalas B ____---___---___---___---_


Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
h) (A OR B) NAND A

*/




Console.WriteLine();
Console.Write(" A atsakymas  - " );
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false && false).ToString().Replace("True", "-").Replace("False", "_")} ");


Console.WriteLine();
Console.Write(" B atsakymas  - ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ||  false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false || false).ToString().Replace("True", "-").Replace("False", "_")} ");


Console.WriteLine();
Console.Write(" C atsakymas  - ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false ^ false).ToString().Replace("True", "-").Replace("False", "_")} ");



Console.WriteLine();
Console.Write(" D atsakymas  - ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");



Console.WriteLine();
Console.Write(" E atsakymas  - ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(true !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(false !|| false).ToString().Replace("True", "-").Replace("False", "_")} ");


Console.WriteLine();
Console.Write(" F atsakymas  - ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false).ToString().Replace("True", "-").Replace("False", "_")} ");


Console.WriteLine();
Console.Write(" G atsakymas  - ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!true || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{(!false || false).ToString().Replace("True", "-").Replace("False", "_")} ");

Console.WriteLine(); 
Console.Write(" H atsakymas  - ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || true) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || true) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || true) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || false) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((true || true) !&& true).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || true) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");
Console.Write($"{((false || false) !&& false).ToString().Replace("True", "-").Replace("False", "_")} ");







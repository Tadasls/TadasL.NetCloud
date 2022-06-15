// See https://aka.ms/new-console-template for more information
Console.WriteLine("&& (AND) , || (OR) , ! (Not), ^ (XOR) ");


Console.WriteLine("Neigimas ! not operatorius");
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

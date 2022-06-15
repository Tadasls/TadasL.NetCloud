// See https://aka.ms/new-console-template for more information
Console.WriteLine("&& (AND) , || (OR) , ! (Not), ^ (XOR) ");


Console.WriteLine("Neigimas ! not operatorius");
bool tiesa = true;
bool melas = !tiesa;
Console.WriteLine($"Tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");
Console.WriteLine($"!melas = {melas}");


Console.WriteLine("AND &&  operatorius");


Console.WriteLine($" tiesa AND Tiesa  {tiesa && tiesa} ");
Console.WriteLine($" tiesa AND melas  {tiesa && melas} ");
Console.WriteLine($" melas AND Tiesa  {melas && tiesa} ");
Console.WriteLine($" melas AND melas  {melas && melas} ");





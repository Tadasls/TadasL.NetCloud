namespace namu_darbai_V001
{
    internal class Program
    {

        static void Main(string[] args)
        {
                            
                        Console.WriteLine("Home Work! to Start, press Enter");
            Console.ReadLine();


            //kintamieji, o D for drawing, Tree Rings
            string D0 = "      |      ";
            string D1 = "     #|#     ";
            string D2 = "    ##|##    ";
            string D3 = "   ###|###   ";
            string D4 = "  ####|####  ";
            string Empty = $"{D0}{D0}{D0}";
            string apatineEilute = "       ----1stulp-------2stulp-------3stulp----";


            //1 task
            Console.WriteLine(" \n Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.");

            string L0 = $"{D0}{D0}{D0}";
            string L1 = $"{D1}{D0}{D0}";
            string L2 = $"{D2}{D0}{D0}";
            string L3 = $"{D3}{D0}{D0}";
            string L4 = $"{D4}{D0}{D0}";


            Console.WriteLine(); //Matrica prasideda

            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //2 task
            Console.WriteLine(" \n Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi");

            L0 = $"{D4}{D0}{D0}";
            L1 = $"{D3}{D0}{D0}";
            L2 = $"{D2}{D0}{D0}";
            L3 = $"{D1}{D0}{D0}";
            L4 = $"{D0}{D0}{D0}";

            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //3 task
            Console.WriteLine(" \n Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {Empty}");
            Console.WriteLine($"2eil. {Empty}");
            Console.WriteLine($"3eil. {Empty}");
            Console.WriteLine($"4eil. {Empty}");
            Console.WriteLine($"5eil. {Empty}");
            Console.WriteLine(apatineEilute);

            //4 task
            L4 = $"{D4}{D4}{D4}";

            Console.WriteLine(" \n Į kiekvieno stulpelio 5 eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {Empty}");
            Console.WriteLine($"2eil. {Empty}");
            Console.WriteLine($"3eil. {Empty}");
            Console.WriteLine($"4eil. {Empty}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //5 task
            L3 = $"{D0}{D0}{D1}";
            L4 = $"{D4}{D3}{D2}";

            Console.WriteLine(" \n Į 1 stulp 5 eil įdėkite 4 dalių elementą, 2 stulp 5 eil - 3 dalių, 3 stulp 4 eil - 1 dalies, 3 stulp 5 eil - 2 dalių, ir išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {Empty}");
            Console.WriteLine($"2eil. {Empty}");
            Console.WriteLine($"3eil. {Empty}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //6 task
            L0 = $"{D0}{D0}{D0}";
            L1 = $"{D0}{D0}{D0}";
            L2 = $"{D0}{D0}{D0}";
            L3 = $"{D1}{D0}{D1}";
            L4 = $"{D4}{D3}{D2}";

            Console.WriteLine(" \n Į 1 stulp 4 eil įdėkite tokį pat elementą kaip yra  3 stulp 4 eil, ir išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //7 task
            L0 = $"{D0}{D2}{D0}";
            L1 = $"{D0}{D2}{D0}";
            L2 = $"{D0}{D2}{D0}";
            L3 = $"{D1}{D2}{D1}";
            L4 = $"{D4}{D2}{D2}";

            Console.WriteLine(" \n Į visas 2 stulp eilutes įdėkite tokį pat elementą kaip yra 3 stulp 5 eil, ir išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //8 task
            L0 = $"{D0}{D0}{D0}";
            L1 = $"{D0}{D0}{D1}";
            L2 = $"{D0}{D0}{D2}";
            L3 = $"{D0}{D0}{D3}";
            L4 = $"{D0}{D0}{D4}";

            Console.WriteLine(" \n į 3 stulp sudėkite teisingą piramidę. 1 stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //9 task

            D1 = D1.Replace('#', '\"');
            D2 = D2.Replace('#', '\"');
            D3 = D3.Replace('#', '\"');
            D4 = D4.Replace('#', '\"');

            L0 = $"{D0}{D0}{D0}";
            L1 = $"{D0}{D0}{D1}";
            L2 = $"{D0}{D0}{D2}";
            L3 = $"{D0}{D0}{D3}";
            L4 = $"{D0}{D0}{D4}";

            Console.WriteLine(" \n pakeiskite visų elementų dizainą iš \" # \" į \' \" \', išveskite Tower of Hanoi");
            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);

            //9 task
            Console.WriteLine(" \n Sukurkite viena eilute: pvz ###|###  ir baigus Spauskite ENTER! \n");
            string userDrawing = Console.ReadLine(); //naujas kintamasis

            L0 = $"    {userDrawing}   {userDrawing}    {  userDrawing}"; //kaip tiksliai sulyginti nemoku..
            L1 = $"{D0}{D0}{D1}";
            L2 = $"{D0}{D0}{D2}";
            L3 = $"{D0}{D0}{D3}";
            L4 = $"{D0}{D0}{D4}";


            Console.WriteLine();
            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(apatineEilute);


            Console.WriteLine(" \n Kodo pabaiga, End");
            //darbas baigtas, einam miegoti.. 
        }
    }
}
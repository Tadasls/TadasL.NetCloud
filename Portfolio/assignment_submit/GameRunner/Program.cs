using GameRunner;
using System.Diagnostics;

IGame game = new Game();

var result = game.Run(@"TestData\map2.txt");
Debug.WriteLine($" steps count: {result}");
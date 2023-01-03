using System.ComponentModel;
namespace GameRunner;
public class Game : IGame
{
    public int Run(string filePath)
    {
        string tempData = File.ReadAllText($"{filePath}");
        string[] dataArray = tempData.Replace("\n", "").Split("\r");
        int x = dataArray[0].Length;
        int y = dataArray.Length;
        List<int[]> possibleExits = new List<int[]> { };
        int[,] field = new int[x, y];
        bool gameOn = true;
        int startingPoint = 0;
        int wall = -1;
        int emptyField = -2;

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (dataArray[i][j].Equals('X')) { field[i, j] = startingPoint; }
                if (dataArray[i][j].Equals('1')) { field[i, j] = wall; }
                else { if (!dataArray[i][j].Equals('X')) { field[i, j] = emptyField; } }
            }
        }
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (i == 0 || i == y - 1)
                {
                    if (field[i, j] == emptyField)
                    {
                        int[] exitField = { i, j };
                        possibleExits.Add(exitField);
                    }
                }
                else
                {
                    if (field[i, 0] == emptyField)
                    {
                        int[] exitField = { i, 0 };
                        possibleExits.Add(exitField);
                    }
                    if (field[i, x - 1] == emptyField)
                    {
                        int[] exitField = { i, x - 1 };
                        possibleExits.Add(exitField);
                    }
                    j = x;
                }
            }
        }
        int z = startingPoint;
        while (gameOn)
        {
            bool visited = false;
            for (int i = 0; i < y - 1; i++)
            {
                for (int j = 0; j < x - 1; j++)
                {
                    if (field[i, j] == z)
                    {
                        if (field[i + 1, j] == emptyField) { field[i + 1, j] = z + 1; visited = true; }
                        if (field[i - 1, j] == emptyField) { field[i - 1, j] = z + 1; visited = true; }
                        if (field[i, j + 1] == emptyField) { field[i, j + 1] = z + 1; visited = true; }
                        if (field[i, j - 1] == emptyField) { field[i, j - 1] = z + 1; visited = true; }
                    }
                }
            }
            foreach (int[] fieldIndex in possibleExits)
            {
                if (field[fieldIndex[0], fieldIndex[1]] != emptyField)
                {
                    int bestResult = field[fieldIndex[0], fieldIndex[1]];
                    gameOn = false;
                    return bestResult;
                }
            }
            if (!visited) { break; }
            z++;
        }
        return 0;
    }
}

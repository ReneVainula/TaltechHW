using System.Diagnostics;

public class Program
{
    static char[][] board = File.ReadAllLines("../../../input0.txt").Select(x=> x.ToCharArray()).ToArray();
    static List<List<char>> rowValues = new List<List<char>>(), colValues = new List<List<char>>(), boxValues = new List<List<char>>();
    public static void Main()
    {
        var res = SolveSudoku();
        Console.WriteLine(new string('-', 25));
        for (int i = 0; i < 9; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 9; j++)
            {
                Console.Write(res[i][j] + " ");
                if (j % 3 == 2) Console.Write("| ");
            }
            Console.WriteLine();
            if (i % 3 == 2) Console.WriteLine(new string('-', 25));
        }


        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < 10000; i++)
        {
            board = File.ReadAllLines($"../../../input{i%2}.txt").Select(x => x.ToCharArray()).ToArray();
            SolveSudoku();
        }
        sw.Stop();
        Console.WriteLine($"Solved 10000 sudokus in {sw.ElapsedMilliseconds} ms");
    }

    static char[][] SolveSudoku()
    {
        InitializeBoard();
        Solve(0, 0);
        return board;
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            rowValues.Add(new List<char>());
            colValues.Add(new List<char>());
            boxValues.Add(new List<char>());
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char cell = board[i][j];
                if (cell == '.') continue;
                int boxIndex = (i / 3) * 3 + (j / 3);
                rowValues[i].Add(cell);
                colValues[j].Add(cell);
                boxValues[boxIndex].Add(cell);
            }
        }
    }

    static bool Solve(int row, int col)
    {
        if (row >= 9 || row == 8 && col > 8) return true;

        char cell = board[row][col];
        while (cell != 'x')
        {
            col++;
            if (col == 9)
            {
                row++;
                col = 0;
            }
            if (row >= 9 || row == 8 && col > 8) return true;

            cell = board[row][col];
        }
        int boxIndex = ((row / 3) * 3) + (col / 3);

        bool isValid = false;

        for (int num = 1; num <= 9; num++)
        {
            char cNum = (char)('0' + num);

            if (rowValues[row].Contains(cNum) || colValues[col].Contains(cNum) || boxValues[boxIndex].Contains(cNum)) continue; // propagate value

            board[row][col] = cNum;
            rowValues[row].Add(cNum);
            colValues[col].Add(cNum);
            boxValues[boxIndex].Add(cNum);

            isValid = Solve(row, col);

            if (isValid)
            {
                return isValid;
            }
            else //backtrack
            {
                board[row][col] = 'x';
                rowValues[row].Remove(cNum);
                colValues[col].Remove(cNum);
                boxValues[boxIndex].Remove(cNum);
            }
        }

        return isValid;
    }
}

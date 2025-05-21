//Backtracking -  N- Queens Problem


using System;

class Program
{
    static void SolveNQueens(int n)
    {
        int[] queens = new int[n];
        Place(queens, 0, n);
    }
    static void Place(int[] queens, int row, int n)
    {
        if (row == n)
        {
            Print(queens, n);
            return;
        }
        for (int col = 0; col < n; col++)
        {
            bool safe = true;
            for(int prevRow = 0; prevRow < row;  prevRow++)
            {
                if (queens[prevRow] == col || Math.Abs(queens[prevRow]- col) == row - prevRow)
                {
                    safe = false;
                    break;
                }
            }
            if (safe)
            {
                queens[row] = col;
                Place(queens, row + 1, n);
            }
        }
    }
    static void Print(int[] queens, int n)
    {
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(queens[i] == j ? "Q": " _ ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        SolveNQueens(n);
    }
}
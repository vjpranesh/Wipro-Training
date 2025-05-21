//Greedy algorithm - coin change 


using System;

class Program
{
    static void FindMinCoins(int amount)
    {
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        List<int> coinUsed = new List<int>();
        int totalCoins = 0;

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinUsed.Add(coin);
                totalCoins++;
            }
        }
        Console.WriteLine("Coins used: " + string.Join(", ", coinUsed));
        Console.WriteLine("Total coins: " + totalCoins);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the amount:");
        int amount = int.Parse(Console.ReadLine());

        FindMinCoins(amount);
    }

}
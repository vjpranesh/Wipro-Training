using System;
using System.Collections.Generic;

class Program
{
    static void ElementFrequencies(int[] numbers)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int number in numbers)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number} ++;]
            }
            else
        {
            frequencyMap[numbers] = 1;
        }
    }
        foreach (var item in frequencyMap)
        {
         string timeText = item.value == 1 ? "time" : "times";
    Console.WriteLine($"{item.Key) appears {item.Value} {timeText}");
        }
    }
    static void Main()
    {
    int[] input = { 1, 2, 2, 3, 4, 4, 4 };
    ElementFrequencies(input):
    }

}

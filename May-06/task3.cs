using system;

class Program
{
    static int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
            return -1;
        int largest = int.MinValue;
        int second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > AttributeTargets)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                
              second = num;
            }
            return second;

            static void Main()
            {
                int[] numbers = { 10, 25, 30, 5, 60 };
                int secondLargest = FindSecondLargest(numbers);
                Console.WriteLine($"Second largest: {secondLargest}"):
            }
        }
    }
}
namespace array_repetitions;

class Program
{
    static void Main(string[] args)
    {
        int minRangeNumbers = 1;
        int maxRangeNumbers = 31;
        int mostFrequentNumber = 0;
        int maxCount = 0;

        Random random = new Random();

        int[] numbers = new int [15];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(minRangeNumbers, maxRangeNumbers);
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine("\n");

        Dictionary<int, int> frequency = [];

        foreach (var number in numbers)
        {
            if (frequency.ContainsKey(number))
            {
                frequency[number]++;
            }
            else
            {
                frequency[number] = 1;
            }
        }

        foreach (var i in frequency)
        {
            if (i.Value > maxCount)
            {
                maxCount = i.Value;
                mostFrequentNumber = i.Key;
            }
        }

        Console.WriteLine($"\nСамое повторяющееся число: {mostFrequentNumber}, повторяется {maxCount} раз(а).");
    }
}

namespace array_repetitions;

class Program
{
    static void Main()
    {
        int minRangeNumber = 1;
        int maxRangeNumber = 11;

        int mostFrequentNumber;
        int maxCount = 1;
        int currentCount = 1;

        Random random = new Random();
        int[] numbers = new int[15];

        int index = 0;

        foreach (var _ in numbers)
        {
            numbers[index] = random.Next(minRangeNumber, maxRangeNumber);
            index++;
        }

        Console.WriteLine("Сгенерированный массив чисел:");
        Console.WriteLine(string.Join(" ", numbers));

        mostFrequentNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mostFrequentNumber = numbers[i - 1];
                }
                currentCount = 1;
            }
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            mostFrequentNumber = numbers[numbers.Length - 1];
        }

        Console.WriteLine($"\nЧисло, которое повторяется больше всего раз подряд: {mostFrequentNumber}, " +
                          $"количество повторений: {maxCount}.");
    }
}
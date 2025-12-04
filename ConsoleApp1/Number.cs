public class NumberProcessor
{
    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}

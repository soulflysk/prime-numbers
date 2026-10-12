
class Program
{
    static void Main()
    {
        Console.Write("Enter max number: ");

        int max = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Prime numbers from 2 to {max}:");

        for (int number = 2; number <= max; number++)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}

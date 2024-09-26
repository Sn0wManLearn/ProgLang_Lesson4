using System;
class Program
{
    static void Main(string[] args)
    {
        bool stop = false;

        while (!stop)
        {
            Console.WriteLine("Введите целое число.");
            string? input = Console.ReadLine();
            if (input == null) continue;
            if (input == "q") break;
            if (Int32.TryParse(input, out int value))
            {
                Console.WriteLine("Введено число {0}", value);
                int sum = 0;
                while (value > 0)
                {
                    sum += value % 10;
                    value /= 10;
                }                
                if (sum > 0 && sum % 2 == 0) break;
            }
            else
            {
                continue;
            }
        }
    }
}
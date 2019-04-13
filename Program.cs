using System;

namespace yandex_contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = readNextNumber();
            if (n < 1)
            {
                return;
            }
            int previousNumber = readNextNumber();
            output(previousNumber);
            int i = 1;
            while (i < n)
            {
                int number = readNextNumber();
                if (number != previousNumber)
                {
                    output(number);
                    previousNumber = number;
                }
                i++;
            }
        }

        private static int readNextNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        private static void output(object value)
        {
            Console.WriteLine(value);
        }
    }
}

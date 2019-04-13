using System;

namespace yandex_contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxResult = 0;
            int counter = 0;
            int n = readNextNumber();
            int i = 0;
            while (i < n)
            {
                int number = readNextNumber();
                if (number == 1)
                {
                    counter++;
                }
                else
                {
                    maxResult = Math.Max(maxResult, counter);
                    counter = 0;
                }
                i++;
            }
            output(Math.Max(maxResult, counter));
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

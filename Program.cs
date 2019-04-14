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
            int sequenceLength = n * 2;

            bool final = false;
            while (!final)
            {
                char[] sequence = new char[n];
                sequence[0] = openingBracket;

            }
        }

        private static char openingBracket = '(';
        private static char closingBracket = ')';
        private static char[] buildNextBracketSequence(char[] previous)
        {

            return previous;
        }
        private static isRightBigger(char[] leftSequence, char[] rightSequence)
        {
            
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

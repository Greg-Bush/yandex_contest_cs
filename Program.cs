using System;
using System.Collections.Generic;

namespace yandex_contest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence1 = readNextString();
            string sequence2 = readNextString();
            if (sequence1.Length != sequence2.Length)
            {
                output(0);
                return;
            }
            else
            {
                var dictionary1 = new Dictionary<char, int>(16);
                var dictionary2 = new Dictionary<char, int>(16);
                for (int i = 0; i < sequence1.Length; i++)
                {
                    char symbol = sequence1[i];
                    if (dictionary1.ContainsKey(symbol))
                    {
                        dictionary1[symbol]++;
                    }
                    else
                    {
                        dictionary1[symbol] = 0;
                    }
                    symbol = sequence2[i];
                    if (dictionary2.ContainsKey(symbol))
                    {
                        dictionary2[symbol]++;
                    }
                    else
                    {
                        dictionary2[symbol] = 0;
                    }
                }
                if (dictionary1.Count != dictionary2.Count)
                {
                    output(0);
                    return;
                }
                else
                {
                    foreach (char symbol in dictionary1.Keys)
                    {
                        if(!dictionary2.ContainsKey(symbol) || dictionary1[symbol] != dictionary2[symbol]){
                            output(0);
                            return;
                        }
                    }
                }
            }
            output(1);
        }
        private static int readNextNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        private static string readNextString()
        {
            return Console.ReadLine();
        }
        private static void output(object value)
        {
            Console.WriteLine(value);
        }
    }
}

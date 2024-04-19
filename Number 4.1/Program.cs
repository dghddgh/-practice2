using System;
using System.Collections.Generic;

namespace Number_4._1
{
    class RomanToIntegerConverter
    {
        private static Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        public static int RomanToInt(string s)
        {
            int result = 0;
        
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }

            return result;
        }
        static void Main()
        {
            Console.WriteLine("Доброго времени суток! Введите римское число: ");
            string romanNumeral = Console.ReadLine();

            int result = RomanToInt(romanNumeral);
            Console.WriteLine("Ловите получившееся число: " + result);
            Console.WriteLine("Были рады вам помочь ^_^ ");
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLib
{
    public static class UkrainianStringUtils
    {

        public static string CountVowels(string input)
        {

            if (string.IsNullOrEmpty(input))
                return "Ви нічого не ввели!";
            string vowels = "аеєиіїоуюяАЕЄИІЇОУЮЯ";
            int count = input.Count(c => vowels.Contains(c));
            return $"Кількість голосних в реченні {count}.";
        }

        public static string CountConsonants(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Ви нічого не ввели!";
            string consonants = "бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩ";
            int count = input.Count(c => consonants.Contains(c));
            return $"Кількість приголосних в реченні: {count}";
        }

        public static string ReverseString(string input)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (input == null || input.Length == 0)
                return "Ви нічого не ввели";
            char[] array = input.ToCharArray();

            Array.Reverse(array);
            return new string(array);
        }
        public static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Ви нічого не ввели!";
            var letters = input.Split(' ');
            StringBuilder resultBuilder = new StringBuilder();
            foreach (var letter in letters)
            {
                HashSet<char> seen = new HashSet<char>();
                foreach (char c in letter)
                {
                    if (!seen.Contains(c))
                    {
                        seen.Add(c);
                        resultBuilder.Append(c);
                    }
                }
                resultBuilder.Append(' ');
            }
            return resultBuilder.ToString();
        }
        public static string RemovePunctuation(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Ви нічого не ввели!";
            return Regex.Replace(input, @"[\p{P}\p{S}]", "");

        }
    }
}

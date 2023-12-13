using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void BetterResize(ref char[] array)
        {
            int size = 0;
            foreach (char i in array)
            {
                if (i != '\0')
                {
                    size++;
                }
            }
            Array.Resize(ref array, size);
        }

        static char[] CleanString(string input)
        {
            string cleanedString = "";
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedString += char.ToLower(c);
                }
            }
            return cleanedString.ToCharArray();
        }

        static bool IsPalindrome(char[] charArray)
        {
            bool result = true;
            char[] newLine = charArray.Reverse().ToArray();
            for (int i = 0; i < newLine.Length; i++)
            {
                if (newLine[i] != charArray[i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Нельзя вводить пустую строку!");
                Environment.Exit(0);
            }

            char[] charArray = CleanString(input);

            bool isPalindrome = IsPalindrome(charArray);

            if (isPalindrome)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом.");
            }

            Console.ReadLine();
        }
    }
}

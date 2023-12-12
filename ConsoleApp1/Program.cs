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
            foreach(char i in array)
            {
                if(i != '\0')
                {
                    size++;                   
                }
            }
            //Array.Resize(ref array, size);
        }

        static void GetLetters(in string getLine, ref char[] setChars)
        {
            for (int i = 0; i < getLine.Length; i++)
            {
                if (Char.IsLetterOrDigit(getLine[i]))
                {
                    setChars[i] = getLine[i];
                }
            }
            BetterResize(ref setChars);
            
        }

        static bool IsPalendrom(in string line)
        {
            bool result = true;
            char[] newLine = line.Reverse().ToArray();
            for (int i = 0 ; i < newLine.Length; i++)
            {
                if(newLine[i] != line[i])
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
            string getLine = Console.ReadLine();

            if(getLine == String.Empty)
            {
                Console.WriteLine("Нельзя вводит пустую строку!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            char[] getLetters = new char[getLine.Length];
            GetLetters(getLine, ref getLetters);
            //bool result = ;

            //if (result)
            //{
            //    Console.WriteLine("Строка является палиндромом.");
            //}
            //else
            //{
            //    Console.WriteLine("Строка не является палиндромом.");
            //}

            Thread.Sleep(3000);
        }
    }
}

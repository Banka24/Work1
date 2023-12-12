using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void GetIntNumbersFromString(in string[] stringArray, ref int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                try
                {
                    intArray[i] = int.Parse(stringArray[i]);
                }
                catch(FormatException)
                {
                    Console.WriteLine($"При конвертации произошла ошибка с этим элементом: {stringArray[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            char[] seperate = { ',' };
            Console.Write("Введите последовательность чисел, разделенных запятой: ");
            string[] getNumbers = Console.ReadLine().Split(seperate, StringSplitOptions.RemoveEmptyEntries);

            if(getNumbers.Length == 0)
            {
                Console.WriteLine("Вы ввели пустую строку - так нельзя!");
                Environment.Exit(0);

            }

            int[] numbersArray = new int[getNumbers.Length];
            GetIntNumbersFromString(getNumbers, ref numbersArray);

            int sumArray = numbersArray.Sum();
            int minValue = numbersArray.Min();
            int maxValue = numbersArray.Max();

            Console.WriteLine($"Сумма чисел: {sumArray}\nНаименьшее число: {minValue}\nНаибольшее число: {maxValue}");
        }
    }
}

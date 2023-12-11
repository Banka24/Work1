using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ChangeFirstElement<T>(ref T[] array, T elem)
        {
           array[0] = elem;          
        }
        static void ChangeLastElement<T>(ref T[] array, T elem)
        {
            array[array.Length - 1] = elem;            
        }

        static void ChangeElement<T>(ref T[] array, int index, T elem)
        {
            array[index] = elem;            
        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 6, 8, 9 };
            Console.WriteLine("1) Первый элемент, 2) Последний эелемент, 3) Любой элемент");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите элемент: ");
            int number = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    ChangeFirstElement(ref myArray, number);
                    break;
                case 2:
                    ChangeLastElement(ref myArray, number);
                    break;
                case 3:
                    Console.Write("Введите индекс элемента");
                    int index = int.Parse(Console.ReadLine());
                    ChangeElement(ref myArray, index, number);
                    break;
                default: Console.WriteLine("Я не знаю такой команды."); break;
            }
        }
    }
}

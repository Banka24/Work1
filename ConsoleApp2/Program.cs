using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Delete<T>(ref T[] array, int index)
        {
            T[] newArray = new T[array.Length - 1];
            for(int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for(int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }

        static void DeleteFirst<T>(ref T[] array)
        {
            Delete(ref array, 0);
        }

        static void DeleteLast<T>(ref T[] array)
        {
            Delete(ref array, array.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 6, 7, 8 };

            DeleteLast(ref myArray);
        }
    }
}

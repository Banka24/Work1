using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "asd43 34";
            bool result = false;
            if (username.Length > 4 && username.Length < 16)
            {
                foreach (char i in username)
                {
                    if (!Char.IsUpper(i) && Char.IsWhiteSpace(i) != ' ')
                    {
                        result = true;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

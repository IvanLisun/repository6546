using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа_Фібоначчі
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < 38; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(n3 + " ");
            }
            Console.Read();
        }
    }
}

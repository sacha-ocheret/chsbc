using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            int sum;
            Console.WriteLine('Числа Фiбаначi');
            Console.Write(n1+ " " + n2 + " ");
            for (int i = 0; i <= 40; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Console.Write(sum + " ");
            }
        }
    }
}

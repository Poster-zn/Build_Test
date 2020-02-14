using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_04  //ok
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("請輸入一個整數數字 = ");
            string input = Console.ReadLine();
            n = int.Parse(input);
            int m = n;

            for (int i = 0; i < m; i++)7

            {
                for (int j= 0; j <= i; j++)
                {
                    Console.Write(n-i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

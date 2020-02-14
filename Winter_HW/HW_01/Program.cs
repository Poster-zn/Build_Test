using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01 //ok
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Write("請輸入一個數字 = ");
            string input = Console.ReadLine();
            i = int.Parse(input);

            if(i % 2 == 0)
            {
                Console.WriteLine("這是偶數");
            }
            else
            {
                Console.WriteLine("這是奇數");
            }
            Console.ReadLine();
        }
    }
}

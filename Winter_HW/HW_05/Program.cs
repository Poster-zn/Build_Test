using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05 //ok
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("請輸入中華民國年份 = ");
            string input = Console.ReadLine();
            i = int.Parse(input) + 1911;

            if(i%4 == 0 || i%100 == 0 || i%400 == 0)
            {
                Console.WriteLine($"民國{input}年是閏年");
            }
            else
            {
                Console.WriteLine($"民國{input}年不是閏年");
            }
            Console.ReadLine();

        }
    }
}

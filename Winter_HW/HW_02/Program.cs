using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("輸入數字字串 = ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if(number%2 == 1)
            {
                Console.WriteLine($"奇數為 = {number}");
            }
            else
            {
                Console.WriteLine($"偶數為 = {number}");
            }
            Console.ReadLine();
        }
    }
}

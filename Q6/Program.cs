using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {//根據日期，傳回今天是本月的上旬，中旬或下旬
            Console.Write("請輸入任意日期 1-31 :");
            string input = Console.ReadLine();
            int day = Convert.ToInt32(input);

            if (day <= 10) 
            { 
              Console.WriteLine("今天是本月上旬"); 
            }
            else
            {
                if(day > 20)
                {
                    Console.WriteLine("今天是本月下旬");
                }
                else
                {
                    Console.WriteLine("今天是本月中旬");
                }
            }
        }
    }
}

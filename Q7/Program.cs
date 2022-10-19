using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {//根據不同時間，傳回不同問安方式
            Console.Write("請輸入任意時間:");
            string input = Console.ReadLine();
            DateTime time = Convert.ToDateTime(input);

            DateTime mon = new DateTime(time.Year,time.Month,time.Day,12,00,00);
            DateTime night = new DateTime(time.Year, time.Month, time.Day, 18, 00, 00);

            if (time < mon)
            {
                Console.WriteLine("早安");                
            }
            else
            {
                if(time >= night)
                {
                    Console.WriteLine("晚安");
                }
                else
                {
                    Console.WriteLine("午安");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {//列出指定年份的每一個星期日

            Console.Write("請輸入任意年份:");
            string input = Console.ReadLine();
            int year=Convert.ToInt32(input);
            DateTime dt = new DateTime(year, 1, 1);
            Console.WriteLine("本年度星期日為");


            for (int i = 0; i < 7; i++)
                {
                    DayOfWeek dtWeek = dt.DayOfWeek;
                    int value = (int)dtWeek;

                    if (value == 0)
                    {
                       for (int k = 0; k < 365; k++)
                       {
                          Console.WriteLine($"{dt.ToString("yyyy/MM/dd")}");
                          dt = dt.AddDays(7);
                          int year1 = dt.Year;                        
                          
                          if (year1 != year)
                          {
                           return;
                          }
                       }   
                    }
                    else
                    {
                        dt = dt.AddDays(1);
                    }
                }
            
            

        }
    }
}

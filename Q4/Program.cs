using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {//取得本月最後一天
            DateTime today=DateTime.Today;
            
            DateTime nextMonth=today.AddMonths(1);
            int month = nextMonth.Month;

            DateTime day = new DateTime(today.Year,month,1);
            DateTime lastDay = day.AddDays(-1);

            Console.WriteLine($"{lastDay.ToString("yyyy/MM/dd")}");





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算圖書下個月歸還時間
            Console.WriteLine("請輸入借書日期 年/月/日");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入");
                return;
            }

            DateTime borrow =Convert.ToDateTime(input);
            DateTime returnday=borrow.AddMonths(1);
            Console.WriteLine($"歸還日期為{returnday.ToString("yyyy年MM月dd日")}");
            
        }
    }
}

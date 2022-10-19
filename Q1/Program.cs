using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算三天後DVD應歸還時間
            Console.WriteLine("請輸入租借日期 年/月/日");
            string input= Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入");
                return;
            }

            DateTime borrow = Convert.ToDateTime(input);

            DateTime returnday = borrow.AddDays(3);
            Console.WriteLine($"歸還日期為{returnday.ToString("yyyy年MM月dd日")}");

        }
    }
}

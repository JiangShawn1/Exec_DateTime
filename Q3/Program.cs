using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {//取得本月1日
            
            DateTime today=DateTime.Today;
            

            Console.WriteLine($"{today.ToString("yyyy/MM/01")}");

            
        }
    }
}

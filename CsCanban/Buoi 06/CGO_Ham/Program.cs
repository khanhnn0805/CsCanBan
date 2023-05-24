using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Ham
{
    internal class Program
    {
        private static void Tinhtong3so(int a, int b, int c)
        {
            
           Console.Write("Nhap gia tri ba so nguyen");
           a = int.Parse(Console.ReadLine());
           b = int.Parse(Console.ReadLine());
           c = int.Parse(Console.ReadLine());
           Console.WriteLine("Tong = " + (a + b + c));
           Console.ReadKey();
        }
        private static void Tinhtich3so(int a, int b, int c)
        {
            
            Console.Write("Nhap gia tri ba so nguyen");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong = " + (a * b * c));
            Console.ReadKey();
      

        }
        
    }
}
 
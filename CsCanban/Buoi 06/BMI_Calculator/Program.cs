using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieuCao;
            double canNang;
            Console.WriteLine("Xin moi nhap chi so can nang");
            chieuCao = double.Parse(Console.ReadLine());
            canNang = double.Parse(Console.ReadLine());
            double bmi = chieuCao / Math.Pow(canNang, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI="+bmi);
            if (bmi < 18)
                Console.WriteLine(" Thieu can");
            else if (bmi < 25.0)
                Console.WriteLine(" BT");
            else if (bmi < 30.0)
                Console.WriteLine(" Thua can");
            else
                Console.WriteLine(" Beo phi");
        }
    }
}

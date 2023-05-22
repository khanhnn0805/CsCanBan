using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_tong_cac_phan_tu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C1: Theo cach dung fo
           
            int[] a = new int[10];
            Console.WriteLine("Vui long nhap phan tu");
            int n = int.Parse(Console.ReadLine());//n la so luong pt

            Console.WriteLine("Nha gia tri cac phan tu");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu [" + i + "]=");
                //luu gia tri vao mang
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Cac gia tri moi nhap");
            for (int i = 0;i<n; i++)
            { Console.WriteLine(a[i]); };

            int tong = 0;
            for (int i = 0; i < n; i++) tong += a[i];
            {
                Console.WriteLine("Tong gia tri trong mang =" + tong);
            }
            

        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XuatNgayGioHeThong();
            XuatHoVaTen();
        }

        private static void XuatHoVaTen()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string name;
            int namSinh;
            Console.WriteLine("Xin moi nhap ten");
            name = Console.ReadLine();


            Console.WriteLine($"Xin chào bạn {name}");
            Console.WriteLine("Bạn sinh năm mấy: ");
            namSinh = int.Parse(Console.ReadLine());
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("Tuổi của bạn là: " + tuoi);
            //C# bắt đầu là STRING () và kết thúc là STRING (toString())
            //Muốn ép kiểu về kiểu mong muốn kieudulieu.Parse
            //String dung bien.Tótring()
        }

        private static void XuatNgayGioHeThong()
        {
            DateTime localDT = DateTime.Now;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Giờ hiện tại là: " + localDT.ToString("dd/MM/yyyy HH:mm:ss"));
            //Level cơ bản hiển thị ra thông tin
            //Xử lý có dấu sử dụng->
            //Console.InputEncoding = System.Text.Encoding.Unicode;
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
        }
    }
}
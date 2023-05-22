namespace MyApp
{
    internal class DiemTB
    {
        static void Maixn(string[] args)
        {
            float diemTB;
            string input = Console.ReadLine();
            diemTB = float.Parse(input);
            if (diemTB >= 8.5)
                Console.WriteLine("Gioi");
            else if (diemTB >= 7.0)
                Console.WriteLine("kha");
            else if (diemTB >= 5.0)
                Console.WriteLine("trung binh");
            else if (diemTB >= 3.0)
                Console.WriteLine("yeu");
            else
                Console.WriteLine("Kha");
            Console.ReadKey();

        }
    }
 
}

namespace MyApp2
{
    static void Main(string[] args)
        string input;
        input = Console.ReadLine();
        DateTime ngaySinh = DateTime.Parse(input);
        DateTime ngayHienTai = DateTime.Now;
        DateTime ngaySinhTiep = new DateTime(DateTime.Now.Year, ngaySinh.Month, ngaySinh.Day);

         int soNgayCho = 0;
            if (ngaySinh > ngayHienTai)
             soNgayCho = (int) (ngaySinh - ngayHienTai).TotalDays;
            else
        ngaySinh = ngaySinh.AddYears(1);
        Console.WriteLine("So ngay toi sinh nhat ban la: " + soNgayCho);
        Console.ReadKey();
    }
}
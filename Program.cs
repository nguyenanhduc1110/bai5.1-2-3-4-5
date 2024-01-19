using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5._1_2_3_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList danhsach = new ArrayList();
            Console.WriteLine("Hay Nhap So San Pham");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Hay Nhap Thong Tin Cho San Pham {i+1}");

                Console.Write("Hay Nhap Ma SP:");
                int  masp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hay Nhap Ten SP:");
                string tensp = Convert.ToString(Console.ReadLine());
                Console.Write("Hay NHap Don Gia:");
                var dongia = Convert.ToSingle(Console.ReadLine());
                Console.Write("Hay Nhap So Luong:");
                int soluong = Convert.ToInt32(Console.ReadLine());

                SanPham sanPham = new SanPham(masp,tensp,dongia,soluong);
                danhsach.Add(sanPham);
            }
            Console.WriteLine("Thong Tin SP");
            foreach (SanPham sanPham in danhsach) 
            {
                sanPham.tinhtien();
                sanPham.inra(); 
            }
            Console.ReadKey ();
        }
    }
}

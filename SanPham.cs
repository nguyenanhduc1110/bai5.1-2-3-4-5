using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5._1_2_3_4_5
{
    internal class SanPham
    {
        public int MaSP { get; set; }
        public string TenSp { get; set; }
        public float  DonGia { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
        public SanPham()
        {
        }
        public SanPham(int masp, string tensp, float dongia, int soluong)
        {
            this.MaSP = masp;
            this.TenSp = tensp;
            this.DonGia = dongia;
            this.SoLuong = soluong;
        }
        public void tinhtien()
        {
            this.ThanhTien = DonGia * SoLuong;
        }
        public void inra()
        {
            Console.WriteLine($"MaSP:{MaSP}\nTenSP:{TenSp}\nDonGia:{DonGia}\nSoLuong:{SoLuong}\nThanh Tien:{ThanhTien}");
        }
    }
}

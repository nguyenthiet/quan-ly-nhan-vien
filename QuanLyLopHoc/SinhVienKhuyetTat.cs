using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc
{
    class SinhVienKhuyetTat:SinhVien
    {
        private double GIAM_GIA = 0.8;
        private int TiLeThuongTat;
        private string LoaiThuongTat;

        public override void Nhap()
        {
            base.Nhap();
            do
            {
                Console.WriteLine("Nhap vao ty le thuong tat:");
                TiLeThuongTat = int.Parse(Console.ReadLine());
                if (TiLeThuongTat < 0 || TiLeThuongTat > 100)
                {
                    Console.WriteLine("Ti le khong hop li.Xin nhap lai.");
                }
            } while (TiLeThuongTat < 0 || TiLeThuongTat > 100);
            Console.WriteLine("Nhap vao loai thuong tat.");
            LoaiThuongTat = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ti le thuong tat la: " + TiLeThuongTat);
            Console.WriteLine("Loai thuong tat: " + LoaiThuongTat);
        }

        public override double TinhTienHoc()
        {
            return (1 - GIAM_GIA) * HOC_PHI_THUONG;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class Designer:NhanVien
    {
        private double TienThuong;

        public double tienThuong
        {
            get
            {
                return TienThuong;
            }

            set
            {
                TienThuong = value;
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao Tien thuong: ");
            TienThuong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("Nhan vien thiet ke.");
            base.Xuat();
            Console.WriteLine("So tien thuong la: " + TienThuong);
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + TienThuong;
        }

    }
}

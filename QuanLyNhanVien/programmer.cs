using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class programmer:NhanVien
    {
        private double TienOvertime;

        public double tienOvertime
        {
            get
            {
                return TienOvertime;
            }

            set
            {
                TienOvertime = value;
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao so tien lam ngoai gio: ");
            TienOvertime = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("Nhan vien lap trinh: ");
            base.Xuat();
            Console.WriteLine("So tien lam ngoai gio: " + TienOvertime);
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + TienOvertime;
        }
    }
}

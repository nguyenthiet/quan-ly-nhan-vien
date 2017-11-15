using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class NhanVien
    {
        protected string MaNV, TenNV, DiaChi;
        protected Ngay NgaySinh=new Ngay();
        protected double HeSoLuong, LuongCanBan;

        public NhanVien()
        {

        }

        public NhanVien(string pMa, string pTen, string pDiaChi, Ngay pNgaySinh, double hsl, double lcb)
        {
            MaNV = pMa;
            TenNV = pTen;
            DiaChi = pDiaChi;
            NgaySinh = pNgaySinh;
            HeSoLuong = hsl;
            LuongCanBan = lcb;
        }

        public NhanVien(NhanVien nv)
        {
            MaNV = nv.MaNV;
            TenNV = nv.TenNV;
            DiaChi = nv.DiaChi;
            NgaySinh = nv.NgaySinh;
            HeSoLuong = nv.HeSoLuong;
            LuongCanBan = nv.LuongCanBan;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap vao Ma Nha Vien: ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Nhap vao Ten nhan vien: ");
            TenNV = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh: ");
            NgaySinh.Nhap();
            Console.WriteLine("Nhap vao He so luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao luong can ban: ");
            LuongCanBan = double.Parse(Console.ReadLine());

        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma NV: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.Write("Ngay sinh:");
            NgaySinh.Xuat();
            Console.WriteLine();
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Luong can ban: " + LuongCanBan);
        }


        public virtual double TinhLuong()
        {
            return HeSoLuong*LuongCanBan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc
{
    class SinhVienNgheo:SinhVien
    {
        private const double GIAM_GIA_NGHEO = 0.7;
        private int SoLuongThanhVienGiaDinh;
        private double ThuNhapTrungBinhThang;

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao so luong thanh vien trong gia dinh:");
            SoLuongThanhVienGiaDinh=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao Thu nhap trung binh thang cua gia dinh: ");
            ThuNhapTrungBinhThang = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So luong thanh vien trong gia dinh la: " + SoLuongThanhVienGiaDinh);
            Console.WriteLine("Thu nhap trung binh la: " + ThuNhapTrungBinhThang);
        }

        public override double TinhTienHoc()
        {
            return (1 - GIAM_GIA_NGHEO) * HOC_PHI_THUONG;
        }
    }
}

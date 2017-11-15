using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            LopHoc lh = new LopHoc();
            lh.Nhap();
            lh.Xuat();
            Console.WriteLine("Tong tien lop hoc la: " + lh.TinhTongTien());
            Console.ReadKey();
        }
    }
}

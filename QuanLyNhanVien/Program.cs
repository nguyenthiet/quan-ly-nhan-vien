using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            CongTy ct = new CongTy();
            ct.Nhap();
            ct.Xuat();
            Console.ReadKey();
        }
    }
}

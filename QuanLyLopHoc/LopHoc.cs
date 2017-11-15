using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc
{
    class LopHoc
    {
        List<SinhVien> lstSinhVien = new List<SinhVien>();
        public void Nhap()
        {
            int luaChon;
            double tienHoc;
            do
            {
                Console.WriteLine("-------------------menu---------------");
                Console.WriteLine("1.Nhap sinh vien thuong.");
                Console.WriteLine("2.Nhap sinh vien ngheo.");
                Console.WriteLine("3.Nhap sinh vien khuyet tat.");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("---------------------------------------");
                do
                {
                    Console.WriteLine("Moi ban nhap vao lua chon:");
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon < 0 || luaChon > 3)
                    {
                        Console.WriteLine("Lua chon khong chinh xac.Xin nhap lai!");
                    }
                } while (luaChon < 0 || luaChon > 3);

                SinhVien sv = null;

                if (luaChon == 1)
                {
                    sv = new SinhVien();

                }
                else if (luaChon == 2)
                {
                    sv = new SinhVienNgheo();
                }
                else if (luaChon == 3)
                {
                    sv = new SinhVienKhuyetTat();
                }
                if (luaChon != 0)
                {
                    sv.Nhap();
                    lstSinhVien.Add(sv);
                }
            } while (luaChon != 0);
        }

        public void Xuat()
        {
            for(int i=0; i<lstSinhVien.Count(); i++)
            {
                lstSinhVien[i].Xuat();
                if(lstSinhVien[i] is SinhVien)
                {
                    Console.WriteLine("Sinh vien thuong.");
                    Console.WriteLine("Hoc phi la: " + lstSinhVien[i].TinhTienHoc());
                }
                else if(lstSinhVien[i] is SinhVienNgheo)
                {
                    Console.WriteLine("SInh vien ngheo.");
                    Console.WriteLine("Hoc phi la: " + lstSinhVien[i].TinhTienHoc());
                }
                else
                {
                    Console.WriteLine("Sinh vien khuyet tat.");
                    Console.WriteLine("Hoc phi la: " + lstSinhVien[i].TinhTienHoc());
                }

            }
        }

        public double TinhTongTien()
        {
            double TongTien = 0;
            for(int i=0; i<lstSinhVien.Count(); i++)
            {
                TongTien += lstSinhVien[i].TinhTienHoc();
            }
            return TongTien;
        }
    }
}

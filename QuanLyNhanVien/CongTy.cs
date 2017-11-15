using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class CongTy
    {
        List<NhanVien> lstNhanVien = new List<NhanVien>();
        
        public void Nhap()
        {
            int luaChon;
            do
            {
                Console.WriteLine("------------Menu------------");
                Console.WriteLine("1.Them nhan vien thuong.");
                Console.WriteLine("2.Them nhan vien Designer.");
                Console.WriteLine("3.Them nhan vien Tester.");
                Console.WriteLine("4.Them nhan vien programmer.");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("----------------------------");
                do
                {
                    Console.WriteLine("Nhap vao lua chon: ");
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon < 0 || luaChon > 4)
                    {
                        Console.WriteLine("Lua chon khong hop le.Xin nhap lai!");
                    }
                } while (luaChon < 0 || luaChon > 4);

                NhanVien nv = null;
                if (luaChon == 1)
                {
                    nv = new NhanVien();

                }
                else if (luaChon == 2)
                {
                    nv = new Designer();
                }
                else if (luaChon == 3)
                {
                    nv = new Tester();
                }
                else if (luaChon == 4)
                {
                    nv = new programmer();
                }

                if (luaChon != 0)
                {
                    nv.Nhap();
                    lstNhanVien.Add(nv);
                }

            } while (luaChon != 0);
        }

        public void Xuat()
        {
            for(int i=0; i<lstNhanVien.Count(); i++)
            {
                lstNhanVien[i].Xuat();
                Console.WriteLine("Luong la: " + lstNhanVien[i].TinhLuong());
            }
        }
    }
}

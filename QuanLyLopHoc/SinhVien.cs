using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLopHoc
{
    class SinhVien
    {
        protected const double HOC_PHI_THUONG = 3000000;
        protected string cmnd, HoTen, Email, sdt;
        protected int KhoaHoc;

        public SinhVien()
        {
            cmnd = HoTen = Email = sdt = "";
            KhoaHoc = 1;
        }

        public virtual void Nhap()
        {
            Console.Write("\nNhap vao so cmnd:");
            cmnd = Console.ReadLine();

            Console.Write("\nNhap vao Ho ten:");
            HoTen = Console.ReadLine();

            Console.Write("\nNhap vao Email:");
            Email = Console.ReadLine();

            Console.Write("\nNhap vao sdt:");
            sdt = Console.ReadLine();

            do
            {
                Console.Write("\n------------------menu---------------");
                Console.WriteLine("1.Ky thuat lap trinh.");
                Console.WriteLine("2.Lap trinh huong doi tuong.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Moi ban nhap vao khoa hoc muon dang ki.");
                KhoaHoc = int.Parse(Console.ReadLine());
                if (KhoaHoc != 1 && KhoaHoc != 2)
                {
                    Console.WriteLine("Khoa hoc khong hop le.Xin kiem tra lai.");
                }
            } while (KhoaHoc != 1 && KhoaHoc != 2);

        }

        public virtual void Xuat()
        {
            Console.WriteLine("So cmnd:" + cmnd);
            Console.WriteLine("Ho ten:" + HoTen);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Sdt: " + sdt);
            if (KhoaHoc == 1)
            {
                Console.WriteLine("Ban da chon khoa hoc ky thuat lapp trinh.");
            }
            else
            {
                Console.WriteLine("Ban da chon khoa hoc lap trinh huong doi tuong.");
            }
        }

        public virtual double TinhTienHoc()
        {
            return HOC_PHI_THUONG;
        }
    }
}

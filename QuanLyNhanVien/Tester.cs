using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class Tester:NhanVien
    {
        private int SoLoi;

        public int _SoLoi
        {
            get
            {
                return SoLoi;
            }

            set
            {
                SoLoi = value;
            }
        }

        public Tester() : base()
        {

        }

        public Tester(string pMa, string pTen, string pDiaChi, Ngay pNgaySinh, double hsl, double lcb,int pSoLoi):base(pMa,pTen,pDiaChi,pNgaySinh,hsl,lcb)
        {
            SoLoi = pSoLoi;
        }

        public Tester(Tester tt) : base((NhanVien)tt) {
            SoLoi = tt.SoLoi;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap vao So loi: ");
            SoLoi = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("Nhan vien kiem tra");
            base.Xuat();
            Console.WriteLine("So loi la: " + SoLoi);
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + 100000 * SoLoi;
        }
    }
}

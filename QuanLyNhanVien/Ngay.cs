using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class Ngay
    {
        private int day, month, year;

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public Ngay()
        {

        }

        public Ngay(int pDay, int pMont, int pYear)
        {
            day = pDay;
            month = pMont;
            year = pYear;
        }

        public Ngay(Ngay n)
        {
            day = n.day;
            month = n.month;
            year = n.year;
        }

        public int NgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                    break;
                case 2:
                    if(nam % 4 == 0 && nam % 100 != 0)
                    {
                        return 29;
                    }
                    return 28;
                    break;
                default:
                    return 30;
            }
                
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao thang: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao nam: ");
            year = int.Parse(Console.ReadLine());
            int ngay = NgayTrongThang(month, year);
            do
            {
                Console.WriteLine("Nhap vao ngay: ");
                day = int.Parse(Console.ReadLine());
                if (day < 0 || day > ngay)
                {
                    Console.WriteLine("Ngay khong dung.xin nhap lai.");
                }
            } while (day < 0 || day > ngay);
        }

        public void Xuat()
        {
            Console.Write(day + "/" + month + "/" + year);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class HocVien
    {
        public int      MaHocVien { get; set; }
        public string   HoTen     { get; set; }
        public DateTime NgaySinh  { get; set; }
        public double   HocPhi    { get; set; }
        public string   Ho
        {
            get
            {
                return HoTen.Split(' ')[0];
            }
        }
        public string Email
        {
            get
            {
                string ten = HoTen.Split(' ')[HoTen.Split(' ').Length - 1];
                return ten.ToLower() + "@edusolution.com";
            }
        }
        public HocVien(int maHocVien, string hoTen, DateTime ngaySinh, double hocPhi)
        {
            MaHocVien = maHocVien;
            HoTen     = hoTen;
            NgaySinh  = ngaySinh;
            HocPhi    = hocPhi > 3000000 ? hocPhi * 0.95 : hocPhi;
        }
        public HocVien()
        {
            Console.WriteLine("Nhap ma hoc vien: ");
            MaHocVien = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ho va ten: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh");
            NgaySinh = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Nhap hoc phi");
            HocPhi = double.Parse(Console.ReadLine());

            if(HocPhi > 3000000)
            {
                HocPhi *= 0.95;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"<<{MaHocVien} co ten {HoTen} co email {Email}>>");
            Console.WriteLine($"So hoc phi: {HocPhi}");
        }
        public static List<HocVien> TimKiemHocVien(List<HocVien> list, string keyword) 
        {
            List<HocVien> result = new List<HocVien>();
            foreach (var hv in list)
            {
                if (hv.HoTen.Contains(keyword))
                {
                    result.Add(hv);
                }
            }
            return result;
        }
    }
}

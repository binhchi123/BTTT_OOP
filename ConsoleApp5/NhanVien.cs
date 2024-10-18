using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class NhanVien
    {
        public int    MaNhanVien  { get; set; }
        public string HoVaTen     { get; set; }
        public string PhongBan    { get; set; }
        public string DiaChi      { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVien()
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            MaNhanVien = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ho va ten: ");
            HoVaTen = Console.ReadLine();

            Console.WriteLine("Nhap phong ban: ");
            PhongBan = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.WriteLine("Nhap so dien thoai: ");
            SoDienThoai = Console.ReadLine();
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<Nhan vien: {HoVaTen} thuoc phong ban {PhongBan} co so dien thoai la {SoDienThoai}>>");
        }
    }
}

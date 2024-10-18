using System;
using System.Collections.Generic;
using System.Linq;namespace ConsoleApp10
{
    public class Nguoi
    {
        public int      MaSo     { get; set; }
        public string   HoTen    { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Ho
        {
            get
            {
                return HoTen.Split(' ')[0];
            }
        }
        public string Dem
        {
            get
            {
                string[] parts = HoTen.Split(' ');
                if (parts.Length > 2)
                {
                    return string.Join(" ", parts, 1, parts.Length - 2);
                }
                return "";
            }
        }
        public string Ten
        {
            get
            {
                string[] parts = HoTen.Split(' ');
                return parts[parts.Length - 1];
            }
        }

        public Nguoi(int MaSo, string HoTen, DateTime NgaySinh)
        {
            this.MaSo     = MaSo;
            this.HoTen    = HoTen;
            this.NgaySinh = NgaySinh;
        }

        public Nguoi()
        {
            Console.WriteLine("Nhap ma so");
            MaSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ho va ten: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<{MaSo} co ho ten la {HoTen} sinh ngay {NgaySinh}>>");
        }
    }
}

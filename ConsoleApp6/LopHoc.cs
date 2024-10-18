using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class LopHoc
    {
        public int    MaLop  { get; set; }
        public string TenLop { get; set; }
        public int    SiSo   { get; set; }
        public string DiaChi { get; set; }
        public string GVCN   { get; set; }

        public LopHoc(int MaLop, string TenLop, int SiSo, string DiaChi, string GVCN)
        {
            this.MaLop  = MaLop;
            this.TenLop = TenLop;
            this.SiSo   = SiSo;
            this.DiaChi = DiaChi;
            this.GVCN   = GVCN;
        }

        public LopHoc()
        {
            Console.WriteLine("Nhap ma lop: ");
            MaLop = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ten lop: ");
            TenLop = Console.ReadLine();

            Console.WriteLine("Nhap si so: ");
            SiSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.WriteLine("Nhap GVCN: ");
            GVCN = Console.ReadLine();
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<Lop {TenLop} co ma lop la {MaLop} o {DiaChi}>>");
            Console.WriteLine($"<<Lop co {SiSo} hoc sinh va co GVCN la {GVCN}>>");
        }
    }
}

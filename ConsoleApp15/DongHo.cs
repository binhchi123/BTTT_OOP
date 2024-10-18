namespace ConsoleApp15
{
    public class DongHo
    {
        public int  Gio        { get; set; }
        public int  Phut       { get; set; }
        public int  Giay       { get; set; }
        public bool LaBuoiSang { get; set; }

        public DongHo(int gio, int phut, int giay, bool laBuoiSang)
        {
            Gio        = gio;
            Phut       = phut;
            Giay       = giay;
            LaBuoiSang = laBuoiSang;
        }

        public DongHo()
        {
            NhapGio();
            NhapPhut();
            NhapGiay();
            Console.WriteLine("La buoi sang (1) hay chieu (0)");
            LaBuoiSang = Console.ReadLine() == "1";
        }

        public void InThongTin()
        {
            string buoi = LaBuoiSang ? "sang" : "chieu";
            Console.WriteLine($"{Gio}:{Phut}:{Giay}");
            Console.WriteLine($"Bay gio la buoi {buoi}");
        }

        public void NhapGio()
        {
            do
            {
                Console.WriteLine("Nhap gio: ");
                Gio = int.Parse(Console.ReadLine());
            }
            while (Gio < 0 || Gio > 23);
        }

        public void NhapPhut()
        {
            do
            {
                Console.WriteLine("Nhap phut: ");
                Phut = int.Parse(Console.ReadLine());
            }
            while (Phut < 0 || Phut > 59);
        }

        public void NhapGiay()
        {
            do
            {
                Console.WriteLine("Nhap giay: ");
                Giay = int.Parse(Console.ReadLine());
            }
            while (Giay < 0 || Giay > 59);
        }

        public DongHo LayKhoangThoiGian(DongHo dh)
        {
            int gioHieu  = Math.Abs(this.Gio - dh.Gio);
            int phutHieu = Math.Abs(this.Phut - dh.Phut);
            int giayHieu = Math.Abs(this.Giay - dh.Giay);
            return new DongHo(gioHieu, phutHieu, gioHieu, true);
        }
    }
}

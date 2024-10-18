namespace ConsoleApp13
{
    public class SoNguyen
    {
        public int  GiaTri      { get; set; }
        public bool LaSoChan    { get; set; }
        public bool LaNguyenTo  { get; set; }
        public bool LaSoDoiXung { get; set; }
        public SoNguyen(int giaTri)
        {
            GiaTri = giaTri;
            KiemTraSoChan();
            KiemTraNguyenTo();
            KiemTraDoiXung();
        }
        public SoNguyen()
        {
            Console.WriteLine("Nhap gia tri so nguyen: ");
            GiaTri = int.Parse(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<So nguyen {GiaTri} {LaSoChan} so chan, {LaNguyenTo} so nguyen to>>");
        }

        public static int Cong(SoNguyen s1, SoNguyen s2)
        {
            return s1.GiaTri + s2.GiaTri;
        }

        private void KiemTraSoChan()
        {
            LaSoChan = GiaTri % 2 == 0;
        }
        private void KiemTraNguyenTo()
        {
            if (GiaTri < 2)
            {
                LaNguyenTo = false;
            }
            else
            {
                LaNguyenTo = true;
                for (int i = 2; i < GiaTri; i++)
                {
                    if (GiaTri % i == 0)
                    {
                        LaNguyenTo = false;
                        break;
                    }
                }
            }
        }
        private void KiemTraDoiXung()
        {
            int soDao = 1;
            int soBanDau = GiaTri;
            while (soBanDau > 0)
            {
                soDao = soDao * 10 + soBanDau % 10;
                soBanDau /= 10;
            }
            LaSoDoiXung = soDao == GiaTri;
        }

        public void NhapSo()
        {
            while (true)
            {
                Console.WriteLine("Nhap so nguyen: ");
                if(int.TryParse(Console.ReadLine(), out int giaTri))
                {
                    GiaTri = giaTri;
                    KiemTraSoChan();
                    KiemTraNguyenTo();
                    KiemTraDoiXung();
                    break;
                }
                else
                {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }
    }
}

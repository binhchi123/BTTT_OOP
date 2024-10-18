namespace ConsoleApp16
{
    public class ThoiGian
    {
        public int  Ngay       { get; set; }
        public int  Thang      { get; set; }
        public int  Nam        { get; set; }
        public bool LaNamNhuan { get; private set; }
        public int  Thu        { get; set; }

        public ThoiGian(int ngay, int thang, int nam)
        {
            Ngay  = ngay;
            Thang = thang;
            Nam   = nam;
            LaNamNhuan = NamNhuan(nam);
            Thu = TinhThu(ngay, thang, nam);
        }

        public ThoiGian()
        {
            NhapNgay();
            NgapThang();
            NhapNam();
            LaNamNhuan = NamNhuan(Nam);
            Thu = TinhThu(Ngay, Thang, Nam);
        }

        public void LayThongTin()
        {
            Console.WriteLine($"Thoi gian hien tai la: Thu {Thu} ngay {Ngay} thang {Thang} nam {Nam}");
            Console.WriteLine($"Day {LaNamNhuan} phai la nam nhuan");
        }

        public void NhapNgay()
        {
            do
            {
                Console.WriteLine("Nhap ngay: ");
                Ngay = int.Parse(Console.ReadLine());
            }
            while (Ngay < 0 || Ngay > 31);
        }

        public void NgapThang()
        {
            do
            {
                Console.WriteLine("Nhap thang: ");
                Thang = int.Parse(Console.ReadLine());
            }
            while (Thang < 0 || Thang > 12);
        }

        public void NhapNam()
        {
            do
            {
                Console.WriteLine("Nhap nam: ");
                Nam = int.Parse(Console.ReadLine());
            }
            while (Nam > 2024);
        }

        public int LayKhoangThoiGian(ThoiGian tg)
        {
            DateTime date1 = new DateTime(this.Nam, this.Thang, this.Ngay);
            DateTime date2 = new DateTime(tg.Nam, tg.Thang, tg.Ngay);
            var comparedDate = date1 - date2;
            return comparedDate.Days;
        }

        private bool NamNhuan(int nam) 
        {
            return (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0);
        } 

        private int TinhThu(int ngay, int thang, int nam)
        {
            DateTime date = new DateTime(nam, thang, ngay);
            return (int)date.DayOfWeek;
        }
    }
}

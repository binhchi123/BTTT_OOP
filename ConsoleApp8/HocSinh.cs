namespace ConsoleApp8
{
    internal class HocSinh
    {
        public string HoTen         { get; set; }
        public string Lop           { get; set; }
        public string NgaySinh      { get; set; }
        public double DiemToan      { get; set; }
        public double DiemVan       { get; set; }
        public double DiemAnh       { get; set; }
        public double DiemTrungBinh { get; set; }
        public HocSinh(string HoTen,
                       string Lop,
                       string NgaySinh,
                       double DiemToan,
                       double DiemVan,
                       double DiemAnh)
        {
            this.HoTen    = HoTen;
            this.Lop      = Lop;
            this.NgaySinh = NgaySinh;
            this.DiemToan = DiemToan;
            this.DiemVan  = DiemVan;
            this.DiemAnh  = DiemAnh;
            DiemTrungBinh = (DiemToan + DiemVan + DiemAnh) / 3;
        }
        public HocSinh() 
        {
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("Nhap lop: ");
            Lop = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh: ");
            NgaySinh = Console.ReadLine();

            Console.WriteLine("Nhap diem toan: ");
            DiemToan = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem van: ");
            DiemVan = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem anh: ");
            DiemAnh = double.Parse(Console.ReadLine());

            DiemTrungBinh = (DiemToan + DiemVan + DiemAnh) / 3;
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<{HoTen} hoc lop {Lop} co diem trung binh la: {DiemTrungBinh}>>");
        }
    }
}

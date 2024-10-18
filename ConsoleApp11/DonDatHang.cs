namespace ConsoleApp11
{
    public class DonDatHang
    {
        public int      MaSoDon    { get; set; }
        public DateTime NgayDat    { get; set; }
        public string   TenSanPham { get; set; }
        public double   DonGia     { get; set; }
        public int      SoLuong    { get; set; }
        public double   ThanhTien  { get; set; }
        public string   GhiChu     { get; set; }

        public DonDatHang(int     MaSoDon,
                         string   TenSanPham,
                         double   DonGia,
                         int      SoLuong,
                         string   GhiChu)
        {
            this.MaSoDon    = MaSoDon;
            NgayDat         = DateTime.Now;
            this.TenSanPham = TenSanPham;
            this.DonGia     = DonGia;
            this.SoLuong    = SoLuong;
            this.GhiChu     = GhiChu;
            ThanhTien       = SoLuong * DonGia;
        }
        public DonDatHang()
        {
            Console.WriteLine("Nhap ma so don: ");
            MaSoDon = int.Parse(Console.ReadLine());

            NgayDat = DateTime.Now;

            Console.WriteLine("Nhap ten san pham: ");
            TenSanPham = Console.ReadLine();

            Console.WriteLine("Nhap don gia: ");
            DonGia = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ghi chu: ");
            GhiChu = Console.ReadLine();

            ThanhTien = SoLuong * DonGia;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Don hang co so {MaSoDon} dat ngay {NgayDat} co tong tien la {ThanhTien}");
        }
    }
}

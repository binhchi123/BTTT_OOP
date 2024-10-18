namespace ConsoleApp19
{
    public class HoDan
    {
        public int SoThanhVien        { get; set; }
        public int SoNha              { get; set; }
        List<Nguoi> DanhSachThanhVien { get; set; }

        public HoDan()
        {
            DanhSachThanhVien = new List<Nguoi>();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so nha: ");
            SoNha = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine("Nhap thong tin tung thanh vien:");
                Nguoi thanhvien = Nguoi.Nhap();
                DanhSachThanhVien.Add(thanhvien);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"So nha: {SoNha}");
            Console.WriteLine($"So thanh vien: {SoThanhVien}");
            foreach(var tv in DanhSachThanhVien)
            {
                tv.HienThi();
            }
        }
    }
}

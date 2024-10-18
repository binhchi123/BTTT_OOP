namespace ConsoleApp3
{
    public class MonAn
    {
        public string TenMonAn        { get; set; }
        public int    GiaBan          { get; set; }
        public string GioiThieu       { get; set; }
        public string NguyenLieuChinh { get; set; }

        public MonAn()
        {
            Console.WriteLine("Nhap ten mon an: ");
            TenMonAn = Console.ReadLine();

            Console.WriteLine("Nhap gia ban: ");
            GiaBan = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gioi thieu: ");
            GioiThieu = Console.ReadLine();

            Console.WriteLine("Nhap nguyen lieu chinh: ");
            NguyenLieuChinh = Console.ReadLine();

        }

        public void InThongTin()
        {
            Console.WriteLine($"<<Mon: {TenMonAn}, {GioiThieu}, duoc lam tu cac nguyen lieu chinh {NguyenLieuChinh}>>");
        }
    }
}

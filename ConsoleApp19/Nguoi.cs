namespace ConsoleApp19
{
    public class Nguoi
    {
        public string CMND       { get; set; }
        public string HoTen      { get; set; }
        public int    NamSinh    { get; set; }
        public string NgheNghiep { get; set; }

        public Nguoi(string cmnd, string hoTen, int namSinh, string ngheNghiep)
        {
            CMND       = cmnd;
            HoTen      = hoTen;
            NamSinh    = namSinh;
            NgheNghiep = ngheNghiep;
        }

        public static Nguoi Nhap()
        {
            Console.WriteLine("Nhap so CMND: ");
            string cmnd = Console.ReadLine();

            Console.WriteLine("Nhap ho va ten: ");
            string hoTen = Console.ReadLine();

            Console.WriteLine("Nhap nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nghe nghiep");
            string ngheNghiep = Console.ReadLine();

            return new Nguoi(cmnd, hoTen, namSinh, ngheNghiep);
        }

        public void HienThi()
        {
            Console.WriteLine($"So CMND: {CMND}");
            Console.WriteLine($"Ho va ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Nghe nghiep: {NgheNghiep}");
        }
    }
}

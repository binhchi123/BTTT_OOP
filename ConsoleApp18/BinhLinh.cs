namespace ConsoleApp18
{
    public class BinhLinh
    {
        public string Ten     { get; set; }
        public int    SucManh { get; set; } = 50;
        public bool   TrangBi { get; set; }

        public BinhLinh(string ten, bool trangBi)
        {
            Ten     = ten;
            TrangBi = trangBi;
        }

        public virtual double TinhSucManh()
        {
            return TrangBi ? SucManh : SucManh;
        }

        public void InThongTin()
        {
            Console.WriteLine($"{Ten} co chi so suc manh {TinhSucManh()}");
        }      

        public static void ChienDau(BinhLinh binhlinh1, BinhLinh binhlinh2)
        {
            double sucmanh1 = binhlinh1.TinhSucManh();
            double sucmanh2 = binhlinh2.TinhSucManh();

            if (sucmanh1 > sucmanh2)
            {
                Console.WriteLine($"{binhlinh1.Ten} thang");
            }
            else if(sucmanh1 < sucmanh2)
            {
                Console.WriteLine($"{binhlinh2.Ten} thang");
            }
            else
            {
                Console.WriteLine("Hai binh linh hoa nhau");
            }
        }
    }
}

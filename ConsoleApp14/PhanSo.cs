namespace ConsoleApp14
{
    public class PhanSo
    {
        public int TuSo   { get; set; }
        public int MauSo  { get; set; }
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo  = tuSo;
            MauSo = mauSo != 0 ? mauSo : 1;
            ToiGian();
        }

        public PhanSo()
        {
            Console.WriteLine("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine($"Phan so la: {TuSo}/{MauSo}");
        }

        private int UCLN(int a, int b)
        {
            while(b != 0)
            {
                int tg = b;
                b = a % b;
                a = tg;
            }
            return a;
        }

        public void ToiGian()
        {
            int ucln  = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /=  ucln;
            if (MauSo < 0) {
                TuSo  = -TuSo;
                MauSo = -MauSo;
            }
        }

        public PhanSo Cong(PhanSo ps)
        {
            int tu  = (this.TuSo * ps.MauSo) + (this.MauSo * ps.TuSo);
            int mau = this.MauSo * ps.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo ps)
        {
            int tu  = (this.TuSo * ps.MauSo) - (this.MauSo * ps.TuSo);
            int mau = this.MauSo * ps.MauSo;
            return new PhanSo(tu, mau);
        }
    }
}

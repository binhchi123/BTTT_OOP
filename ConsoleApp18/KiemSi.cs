namespace ConsoleApp18
{
    public class KiemSi : BinhLinh
    {
        public KiemSi(string ten, bool trangBi) : base(ten, trangBi) { }
        public override double TinhSucManh()
        {
            return TrangBi ? SucManh * 1.5 : SucManh;
        }
    }
}

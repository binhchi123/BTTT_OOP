namespace ConsoleApp18
{
    public class CungThu : BinhLinh
    {
        public CungThu(string ten, bool trangBi) : base(ten, trangBi) { }
        public override double TinhSucManh()
        {
            return TrangBi ? SucManh * 1.3 : SucManh;
        }
    }
}

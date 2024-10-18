namespace ConsoleApp18
{
    public class Linh : BinhLinh
    {
        public Linh(string ten, bool trangBi) : base(ten, trangBi) {}
        public override double TinhSucManh()
        {
            return TrangBi ? SucManh * 1.1 : SucManh;
        }
    }
}

namespace ConsoleApp18
{
    public class DauSi : BinhLinh
    {
        public DauSi(string ten, bool trangBi) : base(ten, trangBi) { }
        public override double TinhSucManh()
        {
            return TrangBi ? SucManh * 1.7 :SucManh;
        }
    }
}

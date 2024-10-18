using System.Net.Sockets;

namespace ConsoleApp17
{
    public class MaTran
    {
        public int    SoHang { get; set; }
        public int    SoCot  { get; set; }
        public int[,] Matrix { get; set; }

        public MaTran(int soHang, int soCot)
        {
            SoHang = soHang;
            SoCot = soCot;
            Matrix = new int[SoHang, SoCot];
        }

        public MaTran()
        {
            Console.WriteLine("Nhap so hang: ");
            SoHang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so cot: ");
            SoCot = int.Parse(Console.ReadLine());

            Matrix = new int[SoHang, SoCot];
            NhapMaTran();
        }

        public void InMaTran()
        {
            Console.WriteLine("Ma tran");
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void NhapMaTran()
        {
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.WriteLine($"Nhap phan tu Matrix[{i}, {j}]: ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public MaTran CongMaTran(MaTran maTranKhac)
        {
            if(this.SoHang != maTranKhac.SoHang || this.SoCot != maTranKhac.SoCot)
            {
                throw new Exception("Hai ma tran phai co cung kich thuoc");
            }
            MaTran result = new MaTran(SoHang, SoCot);
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    result.Matrix[i, j] = this.Matrix[i, j] + maTranKhac.Matrix[i, j];
                }
            }
            return result;
        }
    }
}

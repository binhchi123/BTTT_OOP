using System;
using System.Collections.Generic;
namespace ConsoleApp7
{
    using System;

    public class TroChoiXucXac
    {
        public int  GiaTri_1 { get; set; } 
        public int  GiaTri_2 { get; set; } 
        public bool Thang    { get; private set; }   
        public bool Thua     { get; private set; }   
        public bool Hoa      { get; private set; }    
        public void NhapGiaTri()
        {
            do
            {
                Console.Write("Nhap gia tri cua ban (tu 3 đen 18): ");
                GiaTri_1 = int.Parse(Console.ReadLine());
            } while (GiaTri_1 < 3 || GiaTri_1 > 18); 
        }
        public void BatDau()
        {
            Random random = new Random();
            GiaTri_2 = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            if (GiaTri_1 > GiaTri_2)
            {
                Thang = true;
                Thua  = false;
                Hoa   = false;
            }
            else if (GiaTri_1 < GiaTri_2)
            {
                Thang = false;
                Thua  = true;
                Hoa   = false;
            }
            else
            {
                Thang = false;
                Thua  = false;
                Hoa   = true;
            }
            InThongTin();
        }
        public void InThongTin()
        {
            Console.WriteLine($"Gia tri cua ban: {GiaTri_1}");
            Console.WriteLine($"Gia tri xuc xac: {GiaTri_2}");

            if (Thang)
            {
                Console.WriteLine("Ket qua: Ban đa thang");
            }
            else if (Thua)
            {
                Console.WriteLine("Ket qua: Ban đa thua");
            }
            else if (Hoa)
            {
                Console.WriteLine("Ket qua: Hai ben hoa");
            }
        }
    }
}

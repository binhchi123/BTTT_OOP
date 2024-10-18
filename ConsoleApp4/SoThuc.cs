using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class SoThuc
    {
        private double _GiaTri;
        public double GiaTri    
        { 
          get { return _GiaTri; }
          set 
            { 
                _GiaTri = value;
                LaSoDuong = _GiaTri > 0;
            } 
        }
        private bool _LaSoDuong;
        public bool LaSoDuong
        {
            get { return _LaSoDuong; }
            private set
            {
                _LaSoDuong = value;
            }
        }
        public SoThuc(double GiaTri)
        {
            this.GiaTri = GiaTri;   
        }
        public static double TimMax(SoThuc so1, SoThuc so2, SoThuc so3)
        {
            return Math.Max(so1.GiaTri, Math.Max(so2.GiaTri, so3.GiaTri));
        }
        public double TimCanBacN(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Bac can phai lon hon 0");
            }
            if (GiaTri < 0 && n % 2 == 0)
            {
                throw new AggregateException("Khong the tinh can bac ");
            }
            return Math.Pow(GiaTri, 1.0 / n);
        }
    }
}

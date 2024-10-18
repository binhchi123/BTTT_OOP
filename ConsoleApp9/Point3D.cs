using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double X, double Y, double Z)
        {
            this.X = X; 
            this.Y = Y; 
            this.Z = Z;
        }

        public Point3D()
        {
            Console.WriteLine("Nhap X: ");
            X = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Y: ");
            Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Z: ");
            Z = double.Parse(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine($"<<{X}, {Y}, {Z}>>");
        }

        public double TinhKhoangCach(Point3D point3D) 
        { 
            double deltaX = X - point3D.X;
            double deltaY = Y - point3D.Y;
            double deltaZ = Z - point3D.Z;
            return Math.Sqrt(deltaX *  deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}

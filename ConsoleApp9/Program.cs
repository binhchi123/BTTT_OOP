using ConsoleApp9;

var point3d1 = new Point3D(1, 2, 3);

Console.WriteLine("Nhap toa do X, Y, Z");
var point3d2 = new Point3D();

point3d1.InThongTin();
point3d2.InThongTin();

double khoangCach = point3d1.TinhKhoangCach(point3d2);
Console.WriteLine($"Khoang cach giua 2 diem la: {khoangCach}"); 


using ConsoleApp13;

var so1 = new SoNguyen(5);
so1.InThongTin();
var so2 = new SoNguyen(20);
var so3 = new SoNguyen(30);

int tong = SoNguyen.Cong(so1, so2);
Console.WriteLine($"Tong 2 so la: {tong}");
so1.NhapSo();
so1.InThongTin();
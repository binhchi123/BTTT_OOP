using ConsoleApp15;

var dh1 = new DongHo(10, 31, 25, true);
var dh2 = new DongHo();

dh1.InThongTin();
dh2.InThongTin();

var kc = dh1.LayKhoangThoiGian(dh2);
Console.WriteLine("Khoang thoi gian giua dong ho 1 va dong ho 2");
kc.InThongTin();    
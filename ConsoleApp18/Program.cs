using ConsoleApp18;

var linh = new Linh("Linh", true);
var cungThu = new CungThu("Cung thu", false);
var kiemSi = new KiemSi("Kiem si", true);
var dauSi = new DauSi("Dau si", true);

linh.InThongTin();
cungThu.InThongTin();
kiemSi.InThongTin();
dauSi.InThongTin();

Console.WriteLine("Tran dau giua 2 binh linh");
BinhLinh.ChienDau(dauSi, kiemSi);

Console.WriteLine("Tran dau giua 2 binh linh");
BinhLinh.ChienDau(linh, cungThu);
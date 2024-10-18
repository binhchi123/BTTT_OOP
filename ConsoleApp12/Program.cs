using ConsoleApp12;

List<HocVien> hocViens = new List<HocVien>();
var hv1 = new HocVien(1, "Nguyen Hoang Long", new DateTime(1999,09,28), 5000000);
hocViens.Add(hv1);

var hv2 = new HocVien();
hocViens.Add(hv2);

hv1.InThongTin();
hv2.InThongTin();

Console.WriteLine("Nhap ten hoc vien can tim: ");
string keyword = Console.ReadLine();
List<HocVien> result = HocVien.TimKiemHocVien(hocViens, keyword);
Console.WriteLine("Ket qua tim kiem:");
foreach (var hv in result)
{
    hv.InThongTin();
}
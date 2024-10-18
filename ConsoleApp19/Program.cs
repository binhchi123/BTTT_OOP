using ConsoleApp19;

Console.WriteLine("Nhap so ho dan can quan ly: ");
int soHoDan = int.Parse(Console.ReadLine());    

List<HoDan> danhSachHoDan = new List<HoDan>();
for (int i = 0; i < soHoDan; i++)
{
    Console.WriteLine($"Nhap thong tin cua ho dan thu {i+1}: ");
    HoDan hoDan = new HoDan();
    hoDan.Nhap();
    danhSachHoDan.Add(hoDan);
}

Console.WriteLine("-------------------------------");
Console.WriteLine("Thong tin ve cac ho dan:");
foreach(var hd in danhSachHoDan)
{
    hd.HienThi();
}
Console.ReadLine();
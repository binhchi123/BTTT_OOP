using ConsoleApp16;

var tg1 = new ThoiGian(14,10,2024);
var tg2 = new ThoiGian();

tg1.LayThongTin();
tg2.LayThongTin();

var kc = tg1.LayKhoangThoiGian(tg2);
Console.WriteLine($"Khoang thoi gian giua 2 ngay: {kc}");

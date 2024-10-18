using ConsoleApp10;

var nguoi1 = new Nguoi(1, "Bui Anh Tu", new DateTime(1993,10,03));
nguoi1.InThongTin();

var nguoi2 = new Nguoi();
nguoi2.InThongTin();

Console.WriteLine($"Ho: {nguoi1.Ho}, Dem: {nguoi1.Dem}, Ten: {nguoi1.Ten}");
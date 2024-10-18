using ConsoleApp14;

var ps1 = new PhanSo(6,5);
var ps2 = new PhanSo(3,4);
var ps3 = new PhanSo();
var ps4 = new PhanSo();

ps1.InThongTin();
ps2.InThongTin();
ps3.InThongTin();
ps4.InThongTin();

PhanSo tong = ps1.Cong(ps2);
tong.InThongTin();

PhanSo hieu = ps1.Tru(ps2);
hieu.InThongTin();
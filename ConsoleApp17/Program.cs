using ConsoleApp17;

var mt1 = new MaTran(3,3);
mt1.NhapMaTran();
var mt2 = new MaTran();

mt1.InMaTran();
mt2.InMaTran();

MaTran tong = mt1.CongMaTran(mt2);
Console.WriteLine("Ket qua cong 2 ma tran la: ");
tong.InMaTran();
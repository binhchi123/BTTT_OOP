using ConsoleApp4;

SoThuc so1 = new SoThuc(4);
SoThuc so2 = new SoThuc(9.0);
SoThuc so3 = new SoThuc(3.5);

double max = SoThuc.TimMax(so1, so2, so3);
Console.WriteLine($"Gia tri lon nhat trong 3 so la: {max}");

double canBac2 = so2.TimCanBacN(2);
Console.WriteLine($"Can bac 2 cua so 1 la: {canBac2}");

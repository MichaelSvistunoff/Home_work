Console.Write("Ener point B1: ");
double b1 = int.Parse(Console.ReadLine()!);

Console.Write("Ener point K1: ");
double k1 = int.Parse(Console.ReadLine()!);

Console.Write("Ener point B2: ");
double b2 = int.Parse(Console.ReadLine()!);

Console.Write("Ener point K2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1)/(k1 - k2);
double y = k2*x+b2;

Console.WriteLine($"({x}; {y})");
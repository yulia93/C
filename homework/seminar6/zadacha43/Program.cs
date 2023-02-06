Console.WriteLine("Введите коэффициент b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;
if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямые совпадают");
else if (k1 == k2) System.Console.WriteLine("Прямые параллельны");
else System.Console.WriteLine("Координаты точки пересечения (" + x + " ;" + y + " )");


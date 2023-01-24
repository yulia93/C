System.Console.WriteLine("Введите координату X первой точки"); 
double x1 = Convert.ToDouble(Console.ReadLine()); 

System.Console.WriteLine("Введите координату y первой точки"); 
double y1 = Convert.ToDouble(Console.ReadLine()); 

System.Console.WriteLine("Введите координату z первой точки"); 
double z1 = Convert.ToDouble(Console.ReadLine()); 

System.Console.WriteLine("Введите координату X второй точки"); 
double x2 = Convert.ToDouble(Console.ReadLine()); 

System.Console.WriteLine("Введите координату y второй точки"); 
double y2 = Convert.ToDouble(Console.ReadLine()); 

System.Console.WriteLine("Введите координату z второй  точки"); 
double z2 = Convert.ToDouble(Console.ReadLine()); 

double d = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)) + ((z1 - z2) * (z1 - z2))); 
System.Console.WriteLine("Расстояние между точками равно" + " " + d);


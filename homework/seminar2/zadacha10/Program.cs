System.Console.WriteLine("Введите трехначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = ((a % 100) - ((a % 100) % 10)) / 10;
System.Console.WriteLine($"-->{b}");

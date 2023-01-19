System.Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 99) 
{
   while (a > 999)
   {
      a = a / 10;
   }
   int b = a % 10;
   System.Console.WriteLine(b);
}
else System.Console.WriteLine("третьей цифры нет");

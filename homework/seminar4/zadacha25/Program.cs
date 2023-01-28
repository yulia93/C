// возведение числа А в натуральную степень числа В

System.Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите степень");

int b = int.Parse(Console.ReadLine());

int a_b = 1;

for (int i = 0; i < b; i++)
{
    a_b *= a;
}

System.Console.WriteLine("{0} ^ {1} = {2}", a, b, a_b);
return 0;
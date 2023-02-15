// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int sum(int m, int n)
{
    if (m > n) return 0;
    else return m + sum(m + 1, n);
}

System.Console.WriteLine("--> M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("--> N");
int n = Convert.ToInt32(Console.ReadLine());
if (n > m) System.Console.WriteLine(sum(m, n));
else System.Console.WriteLine(sum(n, m));
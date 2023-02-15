// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ac(int a, int b)
{
    if (a == 0) return b + 1;
    if ((a != 0) && (b == 0)) return Ac(a - 1, 1);
    if ((a > 0) && (b > 0)) return Ac(a - 1, Ac(a, b - 1));
    return Ac(a, b);
}
System.Console.WriteLine("--> M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("--> N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Функция Аккремана для чисел " + m + " и " + n + " равна " + (Ac(m, n)));

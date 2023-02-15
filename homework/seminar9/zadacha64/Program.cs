// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumRec(int a)
{
    if (a == 0) return;
    else System.Console.Write(" " + a);
    NumRec(a - 1);
}

System.Console.WriteLine("--> N");
int n = Convert.ToInt32(Console.ReadLine());
NumRec(n);
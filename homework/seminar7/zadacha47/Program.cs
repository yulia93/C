// задать двумерный массив размером m*n, заполненный случайными вещественными числами

double DoubleRnd(int a, int b)                            // функция на генерацию вещественных чисел в разных диапазонах
{
    Random rnd = new Random();
    double doublernd = a + rnd.NextDouble() * (b - a);
    return doublernd;
}

System.Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = Math.Round(DoubleRnd(-10, 10), 2);
        System.Console.Write(" " + arr[i, j] + " ");
    }
    System.Console.WriteLine();
}
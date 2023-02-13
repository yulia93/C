// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillPrintArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
            System.Console.Write(" " + array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
Random rnd = new Random();
int l = rnd.Next(2, 6);
int m = rnd.Next(2, 6);
int k = rnd.Next(2, 6);
int n = rnd.Next(2, 6);
int[,] arr1 = new int[l, m];
int[,] arr2 = new int[n, k];
FillPrintArray(arr1);
System.Console.WriteLine();
FillPrintArray(arr2);
System.Console.WriteLine();
if (m != n)
{
    System.Console.WriteLine("Перемножение невозможно");
}
else
{
    int[,] resultarr = new int[l, k];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            resultarr[i, j] = 0;
            for (int p = 0; p < arr1.GetLength(1); p++)
            {
                resultarr[i, j] += arr1[i, p] * arr2[p, j];
            }
            System.Console.Write(resultarr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

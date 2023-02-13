// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0,6}", array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = 4;
int k = 4;
int[,] arr = new int[m, k];
int n = 1;
for (int j = 0; j < k; j++)
{
    arr[m - m, j] = n;
    n++;
}
for (int i = m - 3; i < m; i++)
{
    arr[i, k - 1] = n;
    n++;
}
for (int j = k - 2; j >= 0; j--)
{
    arr[m - 1, j] = n;
    n++;
}
for (int i = m - 2; i >= m - 3; i--)
{
    arr[i, k - k] = n;
    n++;
}
for (int j = k - 3; j < k - 1; j++)
{
    arr[m - 3, j] = n;
    n++;
}
for (int i = m - 2; i >= m - 2; i--)
{
    arr[i, k - 2] = n;
    n++;
}
for (int j = k - 3; j > k - k; j--)
{
    arr[m - 2, j] = n;
}
PrintArray(arr);
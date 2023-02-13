// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int[] array)                         //Функция распечатки одномерного массива
{
    for (int i = 0; i < array.Length; i++)

        System.Console.Write(" " + array[i] + " ");
}

void BubbleSort(int[] arr)                                     // Функция сортировки одномерного массива
{
    for (int i = 0; i < arr.Length; i++)

        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int buff = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = buff;
            }
        }
}
void FillPrintArray(int[,] array)                        // Функция на заполнение и распечатку двухмерного массива       
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(100);
            System.Console.Write(" " + array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
Random rnd = new Random();
int[,] col = new int[rnd.Next(2, 9), rnd.Next(2, 9)];
FillPrintArray(col);
System.Console.WriteLine();
int[] row = new int[col.GetLength(1)];

for (int i = 0; i < col.GetLength(0); i++)
{
    for (int j = 0; j < col.GetLength(1); j++)            //создаю одномерный массив из строки и использую функцию сортировки одномерного массива
    {
        row[j] = col[i, j];
        BubbleSort(row);
    }
    PrintArray(row);
    System.Console.WriteLine();
}


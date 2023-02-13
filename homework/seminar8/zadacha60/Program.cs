// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

System.Console.WriteLine("input dimension X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input dimension Y");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input dimension Z");
int z = Convert.ToInt32(Console.ReadLine());
if ((x * y * z) > 90) System.Console.WriteLine("Array is too big for two-digit numbers");
else
{
    int[,,] col = new int[x, y, z];
    int n = 10;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int k = 0; k < col.GetLength(2); k++)
            {
                col[i, j, k] = n;
                System.Console.Write(col[i, j, k] + " " + "[" + i + "," + j + "," + k + "] ");
                n++;
            }
        }
        System.Console.WriteLine();
    }
}

// программа на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента (или указывает что элемента нет)

double DoubleRnd(int a, int b)                          
{
    Random rnd = new Random();
    double doublernd = a + rnd.NextDouble()* (b - a);
    return doublernd;
}
void FillPrintArray(double[,] arr)                      
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(DoubleRnd(-100, 100), digits: 2);
            System.Console.Write(" " + arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] col = new double[m, n];
FillPrintArray(col);
System.Console.WriteLine("Введите номер строки");
int r = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца");
int c = Convert.ToInt32(Console.ReadLine());
if (r > col.GetLength(0) & c > col.GetLength(1)) System.Console.WriteLine("Такого элемента нет");
else System.Console.WriteLine("-->" + col[r, c]);
// задать двумерный массив из целых чисел, найти среднее арифметическое элементов в каждлм столбце

double DoubleRnd(int a, int b)                            
{
    Random rnd = new Random();
    double doublernd = a + rnd.NextDouble() * (b - a);
    return doublernd;
}
void FillPrintArray(double[,] arr)                          
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(DoubleRnd(-100, 100), 2);
            System.Console.Write("{0,6}", arr[i, j] + " ");
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
System.Console.WriteLine();
for (int j = 0; j < col.GetLength(1); j++)                  // цикл для нахождения и распечатки среднего арифметоческого элементов по столбцам  
{
    double sum = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        sum = sum + col[i, j];
    }
    double avg = Math.Round(sum / col.GetLength(0), 1);
    System.Console.Write("{0,6}", avg);
}

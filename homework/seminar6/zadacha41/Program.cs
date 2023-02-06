// ввод с клавиатуры М чисел. посчитать сколько чисел больше 0 ввели

System.Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int sum = 0;
for (int i = 0; i < m; i++)
{
    System.Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) sum = sum + 1;
}
for (int i = 0; i < m; i++)
{
    System.Console.Write(" " + array[i]);
}
System.Console.WriteLine();
System.Console.WriteLine("Количество числе больше 0 равно " + sum);

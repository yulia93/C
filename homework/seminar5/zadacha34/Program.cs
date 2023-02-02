// * задать массив заполненный случайными положительными трехзначными числами. На выходе показывает количество четных чисел в массиве

System.Console.WriteLine("количество элементов массива --> ");

int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];
Random rnd = new Random();

for (int i = 0; i < a; i++)
{
    array[i] = rnd.Next(100, 1000);
    System.Console.WriteLine(" " + array[i]);
}

int count = 0;

for (int i = 0; i < a; i++)
{
    if (array[i] % 2 == 0)
        count = count + 1;
}

System.Console.WriteLine();
System.Console.WriteLine("Количество четных элементов массива равно " + count);


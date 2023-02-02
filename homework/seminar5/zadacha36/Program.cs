// * задать одномерный массив, заполенный случайными числами. найти сумму элементов, стоящих на нечетных позициях

System.Console.WriteLine("--> ");

int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
Random rnd = new Random();

for (int i = 0; i < a; i++)
{
    array[i] = rnd.Next(-100, 100); // пробовала разные варианты (-1000, 1000) , (1, 100) и т д
    System.Console.WriteLine(" " + array[i]);
}

int sum = 0;
for (int i = 0; i < a; i++)
{
    if (i% 2 > 0)
        sum += array[i];
}
Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");



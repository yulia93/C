// * задать массив вещественных чисел. найти разницу между максимальным и мининимальным элементов массива

System.Console.WriteLine("--> ");

int a = Convert.ToInt32(Console.ReadLine());
double [] array = new double [a];
Random rnd = new Random();

for (int i = 0; i < a; i++)
{
    array[i] = rnd.Next(1, 100); 
    System.Console.WriteLine(" " + array[i]);
}


double max = array[0];
double min = array[0];
foreach (var item in array)  
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
double delta = max - min;
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + delta);


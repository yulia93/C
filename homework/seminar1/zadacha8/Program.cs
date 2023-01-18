Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N - 1)
{
    i += 2;
    Console.Write(i + " ");
}
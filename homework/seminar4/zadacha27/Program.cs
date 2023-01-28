// сумма цифр в числе




// функция для вычисления разрядности

int gr(int c)
{
    int i = 0;
    while (c > 0)
    {
        c = c / 10;
        i++;
    }
    return i;
}


System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int z = gr(a);
int sum = 0;
for (int j = 0; j <= z; j++)
{
    int b = a % 10;
    sum = sum + b;
    a = a / 10;
}
System.Console.WriteLine((sum + a));
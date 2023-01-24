System.Console.WriteLine("Введите пятизначное число");

int a = Convert.ToInt32(Console.ReadLine());
string? str = a.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    System.Console.WriteLine("Да");
}

else System.Console.WriteLine("Нет");

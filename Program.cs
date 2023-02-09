// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

if (num >= 100000 || num < 10000)
{
    Console.WriteLine("Введите пятизначное число: ");
}

else if (num <= 99999)
{
    num1 = num / 10000;
    num2 = num % 10;
    num3 = num / 1000 % 10;
    num4 = num % 100 / 10;

    if (num1 == num2 && num3 == num4)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
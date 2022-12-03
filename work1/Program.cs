// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    int num1 = number / 10000;
    int num2 = (number / 1000) % 10;
    int num3 = (number / 100) % 10;
    int num4 = (number / 10) % 10;
    int num5 = number % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Вы нашли палиндром");
    }
    else
    {
        Console.WriteLine("данное число не палиндром");
    }
}
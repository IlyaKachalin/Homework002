// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();

void SecondDigit(int x)
{
    if (x > 99 && x < 1000)
    {
        int secondDigit = (x / 10) % 10;
        Console.WriteLine(secondDigit);
    }
    else Console.WriteLine("Убедитесь, что вы ввели трехзначное число");
}

try
{
Console.Write("Введите трехзначное число ");
int x = Convert.ToInt32(Console.ReadLine());

SecondDigit(x);
}

catch
{
    Console.WriteLine("Нужно ввести целое число");
}
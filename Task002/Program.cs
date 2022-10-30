// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();

int SecondDigit(int x)
{
    int secondDigit = default;
    while (x >= 1000) x = x / 10;
    secondDigit = x % 10;
    return secondDigit;
}


try
{
    Console.Write("Введите  число ");
    int x = Convert.ToInt32(Console.ReadLine());

    int rez = SecondDigit(x);
    Console.WriteLine(rez);
}

catch
{
    Console.WriteLine("Нужно ввести целое число");
}

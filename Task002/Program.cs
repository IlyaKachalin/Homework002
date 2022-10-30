// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();

int SecondDigit(int x)
{
    int secondDigit = ((x%100)%10);
    if (x >= 1000 || x<=-1000)
    {
        x = x / 10;
        secondDigit = x % 10;
    }
    else if (x > -99 && x < 100) Console.WriteLine("Третьей цифры нет");
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

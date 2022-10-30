// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();



bool Check (int x)
{
    return x==6 || x==7;    
}

try
{
Console.Write("Введите целое число ");
int x = Convert.ToInt32(Console.ReadLine());

bool check = Check(x);
Console.WriteLine (check ? "Yes" : "No");
}

catch
{
    Console.WriteLine("Нужно вводить целые числа");
}
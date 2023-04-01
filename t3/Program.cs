// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int number = ReadInt("Введите день недели");

if (number >= 6)
{
    System.Console.WriteLine($"Выходной");
}
else
{
    System.Console.WriteLine($"Не выходной");
}
if (number > 7)
{
    System.Console.WriteLine("Введено некоректное число");
}
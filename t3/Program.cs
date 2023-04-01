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
System.Console.WriteLine("Введите день недели");

string Mon = "Понедельник";
string Tue = "Вторник";
string Wen = "Среда";
string Thu = "Четверг";
string Fri = "Пятница";
string St = "Суббота";
string Sn = "Воскресенье";

var input = int.Parse(Console.ReadLine());

if (input == 1)
{
    System.Console.WriteLine(Mon);
}
else if (input == 2)
{
    System.Console.WriteLine(Tue);
}
else if (input == 3)
{
    System.Console.WriteLine(Wen);
}
else if (input == 4)
{
    System.Console.WriteLine(Thu);
}
else if (input == 5)
{
    System.Console.WriteLine(Fri);
}
else if (input == 6)
{
    System.Console.WriteLine(St);
}
else if (input == 7)
    System.Console.WriteLine(Sn);
if (input >= 6)
{
    System.Console.WriteLine($"Выходной");
}
else
{
    System.Console.WriteLine($"Не выходной");
}
if (input > 7)
{
    System.Console.WriteLine("Введено некоректное число");
}
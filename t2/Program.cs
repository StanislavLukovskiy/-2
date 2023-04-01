﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Не использовать строки для расчета (решать только при помощи операций % и /).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string message)
{
Console.Write($"{message} >");
int value = Convert.ToInt32(Console.ReadLine());
return value;
}
int number = ReadInt("Введите число");
if (number >= 100)
{
int lastDigit = number / 10 % 10; // Определение трейтьей цифры числа
System.Console.WriteLine($"Третья цифра числа {number} равна {lastDigit}");
}
else
{
   System.Console.WriteLine($"Третья цифра не присутствует");
}
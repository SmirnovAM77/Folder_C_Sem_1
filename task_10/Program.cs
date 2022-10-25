﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int num3 = Convert.ToInt32 (Console.ReadLine());
if (Math.Abs(num3) > 99 && Math.Abs(num3) < 1000 )  // проверка по модулю, является ли число трехзначным
{
    int Work_2(int secnumb)
{
    return secnumb / 10 % 10;
}
int work_2 = Math.Abs(Work_2(num3));
Console.WriteLine($"вторая цифра числа {num3} - это {work_2}");
}
else 
{
    Console.WriteLine("нужно трехзначное число");
}

﻿// 0. Демонстрация решения
// Напишите программу, которая на вход
// 1. принимает число и выдаёт его квадрат (число
// 2. умноженное на само себя).
// 3. выдает квадрат
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32 (Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");




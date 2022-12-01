// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NaturalNumbersToN(int num)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumbersToN (num - 1);
}

Console.WriteLine("Задайте натуральное число N");
int number = Convert.ToInt32 (Console.ReadLine());
if (number > 1)
{
    Console.Write($"N = {number} -> ");
    NaturalNumbersToN(number);
}
else Console.WriteLine("Введите натуоальное число больше 0");

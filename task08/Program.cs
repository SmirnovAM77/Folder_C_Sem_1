// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a <= 2)
{
    Console.WriteLine("Введите число более или равное 2");
}

int numa = 2;

 while (numa <= a)
 {
    Console.Write($"{numa}, "); 
    numa = numa + 2;
 }

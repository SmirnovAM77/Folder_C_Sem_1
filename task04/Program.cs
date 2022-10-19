// "Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22"


Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третье число: ");
int d = Convert.ToInt32 (Console.ReadLine());
int max;

if (a == b && b == d)
{Console.WriteLine($"Числа равны");}
else
{
if (a > b)
{max = a;}
else
{max = b;}

if (d > max)
{max = d;}

Console.WriteLine($"Максимальное число - {max}"); 
}

 

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int chislo = Math.Abs(Convert.ToInt32 (Console.ReadLine()));

void Cubus (int chisloCub)
{
    int cubus = 0;
    for (int i = 1; i <= chisloCub; i++)
    {
        cubus = i*i*i;
        Console.WriteLine($"{i} | {cubus}");
    }
}

Cubus (chislo);

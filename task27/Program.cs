// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32 (Console.ReadLine());

int SummNumb (int num)
{
    num = Math.Abs(num); //берем модуль, если вдруг пользователь ввел отрицательно число
    int buffer = 0;
    int summ = 0;
    while (num >= 1)
    {
        buffer = num % 10;
        num = num / 10;
        summ = summ + buffer;
    }
    return summ;
}

int summNumb = SummNumb (a);
Console.WriteLine($"Сумма всех цифр числа {a} -> {summNumb}");

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
    while (num > 1)
    {
        buffer = num % 10;
        num = num / 10;
        summ = summ + buffer;
    }
    return summ;
}

int summNumb = SummNumb (a);
Console.WriteLine($"Сумма всех цифр числа {a} -> {summNumb}");



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число, возводимое в степень: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуриальную степень данного числа: "); 
// int aB = Convert.ToInt32 (Console.ReadLine());

// int PowerNum (int num, int power)
// {
//     int summ = num;
//     for (int i = 1; i < power; i++)
//         {
//             summ *= num;
//         }
//     if (power==0) summ = 1; // примем, что "0" - тоже натуральное число
//     return summ;
// }

// int powerNum = PowerNum (a, aB);
// Console.WriteLine(aB < 0 ? "Введите натуриальное число." : $"Число {a}, возведенное в степень {aB} - это {powerNum}");

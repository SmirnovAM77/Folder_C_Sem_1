// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число, возводимое в степень: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите натуриальную степень данного числа: "); 
int aB = Convert.ToInt32 (Console.ReadLine());

int PowerNum (int num, int power)
{
    int summ = num;
    for (int i = 1; i < power; i++)
        {
            summ *= num;
        }
    if (power==0) summ = 1; // примем, что "0" - тоже натуральное число
    return summ;
}

int powerNum = PowerNum (a, aB);
Console.WriteLine(aB < 0 ? "Введите натуриальное число." : $"Число {a}, возведенное в степень {aB} - это {powerNum}");

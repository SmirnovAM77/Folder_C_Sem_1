// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любе целое число: ");
int num_new = Convert.ToInt32 (Console.ReadLine());

if (Math.Abs(num_new) > 99 )
{
    int Work_3(int num_new_index)
    {
    num_new_index = Math.Abs(num_new);
    while (num_new_index > 999)
    {
        num_new_index = num_new_index / 10;
    }
    return num_new_index % 10;
    }
    int num3 = Math.Abs(Work_3(num_new));
    Console.WriteLine($"третья цифра числа {num_new} - это {num3}");
}
else 
{
    Console.WriteLine("третьей цифры нет");
}


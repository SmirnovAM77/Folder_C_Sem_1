// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7 включительно: ");
int day = Convert.ToInt32 (Console.ReadLine());
if (day > 0 && day < 8)
{
    bool Holliday (int day_num)    
{
        return day_num > 5;      // можно не ограничивать верхней границей "7", так как до этого оператор "if" уже отсекает все, что больше 7
}
    bool holliday = Holliday(day);
    Console.WriteLine(holliday ? "выходной" : "будний");
}
else
{
    Console.WriteLine("цифру от 1 до 7 !");
}

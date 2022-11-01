
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Универсальный способ!

Console.Write("Введите положительное (как минимум двухзначное), число: ");
int chislo = Convert.ToInt32 (Console.ReadLine());
void Palind(int newPal)
{
    if (newPal < 10) 
    {
        Console.Write("Нужно было ввести положительное и минимум двухзначное число");
    }
    else
    {
    int dlinaStrok= newPal.ToString().Length;
    int i = 0;
    int newN = 0;
     while (i < dlinaStrok)
    {
        int stepen = (int) Math.Pow(10,i);
        int bufer=newPal/stepen;
        int bufer2=bufer%10;
        int stepen2 = (int) Math.Pow(10, dlinaStrok-i-1);
        int bufer4 = bufer2*stepen2;
        newN = newN + bufer4;
        i++;
    }
    Console.WriteLine(newPal == newN ? $"число {newPal} - палиндром" : $"число {newPal} - НЕ палиндром");
    }
}
Palind (chislo);

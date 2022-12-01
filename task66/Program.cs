// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int NaturalNumbersToN(int numM, int numN)
{
    if (numN >= numM)
    {
        if (numN == numM) return numN;
        return numM + NaturalNumbersToN(numM + 1, numN);
    }
    else
    {
        if (numN == numM) return numM;
        return numN + NaturalNumbersToN(numM, numN + 1);
    }
}

Console.WriteLine("Задайте натуральное число M");
int numberM = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Задайте натуральное число N");
int numberN = Convert.ToInt32 (Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    int naturalNumbersToN = NaturalNumbersToN (numberM, numberN);
    Console.WriteLine($"Сумма натуральных чисел между {numberM} и {numberN} равняется {naturalNumbersToN}");
}
else Console.WriteLine("Введите натуоальное число больше 0");

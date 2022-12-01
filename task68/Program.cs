// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AkkermanFunction(int m, int n)
{
if (m == 0)
{
return n + 1;
}
if ((m > 0) && (n == 0))
{
return AkkermanFunction(m - 1, 1);
}
if ((m > 0) && (n > 0))
{
return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
} 
return n + 1;
}

Console.WriteLine("Задайте неотрицательное число m");
int numberM = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Задайте неотрицательное число n");
int numberN = Convert.ToInt32 (Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int akkermanFunction = AkkermanFunction (numberM, numberN);
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m ,n) = {akkermanFunction}");
}
else Console.WriteLine("Введите натуральные неотрицательные числа");

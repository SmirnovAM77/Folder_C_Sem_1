// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для данных уравнений y = k1 * x + b1, y = k2 * x + b2 введите коэффициенты:");
Console.WriteLine("коэффициент b1:");
int b1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("коэффициент k1:");
int k1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("коэффициент b2:");
int b2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("коэффициент k2:");
int k2 = Convert.ToInt32 (Console.ReadLine());

double Xposition (double b1x, double k1x, double b2x, double k2x)
{
    double coordinat = (b2x - b1x) / (k1x - k2x);
    return coordinat;
}

double Yposition (double b1y, double k1y, double b2y, double k2y)
{
    double coordinat = (b1y * k2y - b2y * k1y) / (k2y - k1y);
    return coordinat;
}

double хposition = Xposition(b1, k1, b2, k2);
double yposition = Yposition(b1, k1, b2, k2);
Console.WriteLine($"Координаты точки перечения - ({хposition} ; {хposition})");

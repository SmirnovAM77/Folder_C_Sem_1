// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X первой точки: ");
int ax = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int ay = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int az = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("___________________________________");
Console.Write("Введите координату X второй точки: ");
int bx = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int by = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int bz = Convert.ToInt32 (Console.ReadLine());

double Vektor (int axN, int ayN, int azN, int bxN, int byN, int bzN)
{
    double dlina = Math.Sqrt((bxN-axN)*(bxN-axN) + (byN-ayN)*(byN-ayN) + (bzN-azN)*(bzN-azN));
    return dlina;
}

double vektor = Math.Round (Vektor (ax, ay, az, bx, by, bz), 2);

Console.Write($"Расстояние между двумя точками A ({ax},{ay},{az}) и B ({bx},{by},{bz}) : {vektor}");


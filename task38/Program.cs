// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, int min, int max)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.NextDouble()*(max-min)+min; //рандномное вещественное число
array[i] = Math.Round(array[i], 1);  //округление до 1 знака после запятой
}
return array;
}

void PrintArray(double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

double MaxNumber (double[] array)
{   
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumber (double[] array)
{   
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double FromMaxToMin (double max, double min)
{   
    double different = max - min;
    return different;
}

double[] arr = CreateArrayRndInt(4, -90, 90);
PrintArray(arr);
double maxNumber = MaxNumber(arr);
double minNumber = MinNumber(arr);
double fromMaxToMin = FromMaxToMin(maxNumber, minNumber);
Console.WriteLine($"разницу между максимальным и минимальным элементами массива = {fromMaxToMin}");
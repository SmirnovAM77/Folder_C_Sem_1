// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину желаемого массива: ");
int len = Convert.ToInt32 (Console.ReadLine());

int[] NewArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void PrintArray (int[] arrayP)
{
    int arrayPLength = (arrayP.Length-1);
    Console.Write("[");
    for (int i = 0; i < arrayPLength; i++)
    {
        Console.Write($"{arrayP[i]}, ");
    }   
    Console.Write($"{arrayP[arrayPLength]}]");
}

if (len > 0)
{
    int[] newArray = NewArray (len);
    PrintArray (newArray);
}
else
{
    Console.WriteLine("Введите число более 0");
}
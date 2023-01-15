// Написать программу, которая из имеющего массива строк, формирует массив строк,длинна которых сотсоалвяет 3 символа или меньше.



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину желаемого массива: ");
int len = Convert.ToInt32 (Console.ReadLine());

int[] NewArray (int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0,3000);
    }
    return array;
}

int[] ArrayForPrint (int[] array, int length)
{
    int[] array3 = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 999) array3[i] = array[i];
    }
    
    return array3;
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

if (len > 3)
{
    int[] newArray = NewArray (len);
    PrintArray (newArray);
    Console.WriteLine();
    int[] arrayForPrint = ArrayForPrint (newArray, len);
    PrintArray (arrayForPrint);
}
else
{
    Console.WriteLine("Введите число более 3");
}
// Написать программу, которая из имеющего массива строк, формирует массив строк,длинна которых сотсоалвяет 3 символа или меньше.


Console.WriteLine("Введите длину желаемого массива: ");
int len = Convert.ToInt32 (Console.ReadLine());

int[] NewArray (int length)
// формирование рандомного массива
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
// Формирует новый массив, согласно заданию
{
    int[] array3 = new int[length];
    int indexArray3 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 999) 
            {
                array3[indexArray3] = array[i];
                indexArray3 += 1;
            }
    }
    return array3;
}

void PrintArray (int[] arrayP)
// программа для распечатывания сначала исходного массива, затем необходимого по задаче массива
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
    Console.WriteLine("Начальный массив");
    int[] newArray = NewArray (len);
    PrintArray (newArray);
    Console.WriteLine();
    Console.WriteLine("Итоговый массив");
    int[] arrayForPrint = ArrayForPrint (newArray, len);
    PrintArray (arrayForPrint);
}
else
{
    Console.WriteLine("Введите число более 3");
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите, какое будет количество чисел: ");
int mArrayLenght = Convert.ToInt32 (Console.ReadLine());

int[] CreateMArray(int length)
{
int[] array = new int[length];
Console.WriteLine("Введите числа (после каждого нажмите Enter): ");
for (int i = 0; i < length; i++)
{
    array[i] = Convert.ToInt32 (Console.ReadLine());
}
return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.Write("]");
}

int MoreThanZero (int[] array)
{   
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) numbers += 1;
    }
    return numbers;
}

int[] arr = CreateMArray(mArrayLenght);
int moreThanZero = MoreThanZero (arr);
PrintArray(arr);
Console.WriteLine($" -> в данном случе чисел, которые больше ноля - {moreThanZero}");

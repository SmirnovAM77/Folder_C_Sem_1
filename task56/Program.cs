// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[] SummOfRows(int[,] matrix)
{
    int[] summ = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                summ[i] += matrix[i, j];
            }
        }
return summ;
}

int MinimuSummRow(int[] arr)
{
    int row = 0;
    int buff = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < buff) 
        {
            row = i;
            buff = arr[i];
        }
    }
    return row + 1; //добавляем единицу, чтобы было понятно пользователю, так как система считает строки с "0".
}

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
}
return matrix;
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
        else Console.Write($"{matrix[i, j], 4}");
    }
    Console.WriteLine(" |");
}
}

Console.WriteLine("Задайте массив.");
Console.Write("Количество строк:  ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write("Количество столбцов:   ");
int column = Convert.ToInt32 (Console.ReadLine());

int[,] createMatrix = CreateMatrix(row, column, -3, 3);
PrintArray(createMatrix);
int[] summOfRows = SummOfRows(createMatrix);
int minimuSummRow = MinimuSummRow(summOfRows);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minimuSummRow}");
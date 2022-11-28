// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] ArrangMatrixRowFromMaxToMin(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int variable = default;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       for (int k = 0; k < matrix.GetLength(1); k++)
       {    
        if (matrix[i, j] >= matrix[i, k]) 
        {
            variable = matrix[i, k];
            matrix[i, k] = matrix[i, j];
            matrix[i, j] = variable;
        }
       }
    }
}
return matrix;
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

int[,] createMatrix = CreateMatrix(row, column, -90, 90);
PrintArray(createMatrix);
int[,] arrangMatrixRowFromMaxToMin = ArrangMatrixRowFromMaxToMin(createMatrix);
Console.WriteLine();
PrintArray(arrangMatrixRowFromMaxToMin);


// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] MultiplicationOfMatrix(int[,] matrixOne, int[,] matrixTwo)
{
int buff = default;
int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
for (int i = 0; i < matrixOne.GetLength(0); i++)
{
    for (int j = 0; j < matrixTwo.GetLength(1); j++)
    {
        for (int k = 0; k < matrixOne.GetLength(1); k++)
        {
            buff = matrixOne[i,k]*matrixTwo[k,j];
            matrix[i, j] += buff;
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

Console.WriteLine("Задайте Первую матрицу.");
Console.Write("Количество строк:  ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write("Количество столбцов:   ");
int column = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Задайте Вторую матрицу.");
Console.Write("Количество строк:  ");
int rowSecondMatrix = Convert.ToInt32 (Console.ReadLine());
Console.Write("Количество столбцов:   ");
int columnSecondMatrix = Convert.ToInt32 (Console.ReadLine());

if (column == rowSecondMatrix)
{
    Console.WriteLine("Первая Матрица:");
    int[,] createMatrix = CreateMatrix(row, column, 2, 4);
    PrintArray(createMatrix);
    Console.WriteLine("Вторая Матрица:");
    int[,] createMatrixSecond = CreateMatrix(rowSecondMatrix, columnSecondMatrix, 2, 4);
    PrintArray(createMatrixSecond);
    Console.WriteLine("Результирующая матрица:");
    int[,] multiplicationOfMatrix = MultiplicationOfMatrix(createMatrix, createMatrixSecond);
    PrintArray(multiplicationOfMatrix);
}
else 
{
    Console.WriteLine("Данные матрицы несогласованные - перемножить нельзя");
}
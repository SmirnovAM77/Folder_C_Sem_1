// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

bool MatrixElement(int[,] matrix, int rows, int columns)
{
    if (matrix.GetLength(0) >= rows && matrix.GetLength(1) >= columns) return true;
    else return false;
}


Console.WriteLine("Введите позицию элемента массив.");
Console.Write("позицию строки:  ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write("позицию столбца:   ");
int column = Convert.ToInt32 (Console.ReadLine());


int[,] newmatrix = CreateMatrix(4, 5, -90, 90);
bool matrixElement = MatrixElement(newmatrix, row, column);
PrintArray(newmatrix);
Console.WriteLine(matrixElement? $"елемент ({row}, {column}) в массиве есть" : $"елемента ({row}, {column}) в массиве нет");

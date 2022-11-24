// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9




double[,] CreateMatrix(int rows, int columns, int min, int max)
{
double[,] matrix = new double[rows, columns];
Random rnd = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = rnd.NextDouble()*(max-min)+min; //рандномное вещественное число
        matrix[i, j] = Math.Round(matrix[i, j], 1); //округление до 1 знака после запятой
    }
}
return matrix;
}


// double[] CreateArrayRndInt(int size, int min, int max)
// {
// double[] array = new double[size];
// Random rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// array[i] = rnd.NextDouble()*(max-min)+min; //рандномное вещественное число
// array[i] = Math.Round(array[i], 1);  //округление до 1 знака после запятой
// }
// return array;
// }


void PrintArray(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
        else Console.Write($"{matrix[i, j], 4}");
    }
    Console.WriteLine(" |");
}
}

Console.WriteLine("Создадим двумерный массив.");
Console.Write("введите количество строк:      ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write("введите количество столбцов:   ");
int n = Convert.ToInt32 (Console.ReadLine());


double[,] newmatrix = CreateMatrix(m, n, -10, 10);
// bool matrixElement = MatrixElement(newmatrix, row, column);
PrintArray(newmatrix);
// Console.WriteLine(matrixElement? $"елемент ({row}, {column}) в массиве есть" : $"елемента ({row}, {column}) в массиве нет");
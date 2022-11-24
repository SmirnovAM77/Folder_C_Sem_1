// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMean(int[,] matrix)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double mean = 0;
    int zeroNum = 0;           
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        mean += matrix[i, j];
        if (matrix[i, j] == 0) zeroNum++; 
    }
    mean = mean / (matrix.GetLength(0) - zeroNum);  //если нам встречается "0", то мы делим на количество строк за минусом строки с "0"
    mean = Math.Round(mean, 1); //округление до 1 знака после запятой
    Console.Write($"{mean, 5}; ");
}
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

int[,] newmatrix = CreateMatrix(4, 4, 0, 5);
PrintArray(newmatrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
ArithmeticMean(newmatrix);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrix(int rows, int columns)
{
int[,] matrix = new int[rows, columns];

for (int j = 0; j < columns; j++) //1-4
    {
        matrix[0, j] = 1+j;
    }

for (int i = 1; i < rows; i++) //4-7
    {
        matrix[i, columns-1] = matrix[i-1, columns-1] + 1;
    }

for (int j = 1; j < columns; j++) //7-10
    {
        matrix[ rows-1, columns - j -1] = matrix[rows-1, columns-j]+1;
    }

for (int i = 1; i < rows-1; i++) //10-12
    {
        matrix[rows-i-1, columns-columns] = matrix[rows-i, columns-columns] + 1;
    }

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = rnd.Next(2, 19 + 1);
//     }
// }

// int[,] matrix = new int[rows, columns];
// Random rnd = new Random();
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = rnd.Next(2, 19 + 1);
//     }
// }
return matrix;
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} | ");
        else Console.Write($"{matrix[i, j], 2}");
    }
    Console.WriteLine(" |");
}
}

Console.WriteLine("Задайте массив.");
Console.Write("Количество строк:  ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write("Количество столбцов:   ");
int column = Convert.ToInt32 (Console.ReadLine());

int[,] createMatrix = CreateMatrix(row, column);
PrintArray(createMatrix);

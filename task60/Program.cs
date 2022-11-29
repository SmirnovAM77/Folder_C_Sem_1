// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix(int rows, int columns, int depth)
{
int[,,] matrix = new int[rows, columns, depth];
int num = -99;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < depth; k++)
        {
            matrix[i, j, k] = num;
            num +=1;
        }
    }
}
return matrix;
}

void PrintArray(int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         for (int k = 0; k < matrix.GetLength(2); k++)
         {
           Console.Write($"{matrix[i, j, k], 2}({i}, {j}, {k})  "); 
         }
    }
    Console.WriteLine();
}
}

Console.WriteLine("Задайте массив.");
Console.Write("Количество строк:  ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write("Количество столбцов:   ");
int column = Convert.ToInt32 (Console.ReadLine());
Console.Write("Глубина массива:   ");
int depth = Convert.ToInt32 (Console.ReadLine());

if ((row*column*depth) < 200)
{
    int[,,] createMatrix = CreateMatrix(row, column, depth);
    PrintArray(createMatrix);
}
else 
{
    Console.WriteLine("Заданный массив слишком большой.");
}
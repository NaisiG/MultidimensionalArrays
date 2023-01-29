// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбец
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],  5}, ");
            else Console.Write($"{matrix[i, j], 5}  ");            
        }
        Console.WriteLine("]");
        
    }
}

void ChangeFirsAndLastRows(int[,] matrixForChange)
{
    int firstRow = 0;
    int lastRow = matrixForChange.GetLength(0) - 1;
    for (int i = 0; i < matrixForChange.GetLength(0); i++) 
    {
        int temp = matrixForChange[firstRow, i];
        matrixForChange[firstRow, i] = matrixForChange[lastRow, i];
        matrixForChange[lastRow, i] = temp;
    }    
}


int matrixRows = 5;
int matrixColumns = 5;
int matrixMinVolue = 1;
int matrixMaxVolue =11;

int[,] matrix = CreateMatrixRndInt(matrixRows, matrixColumns, matrixMinVolue, matrixMaxVolue);
PrintMatrix(matrix);
ChangeFirsAndLastRows(matrix);
Console.WriteLine(string.Empty);
PrintMatrix(matrix);

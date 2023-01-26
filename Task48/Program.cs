// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент массиве находится по формуле: Amn = m + n.
// Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumInd(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбец
        {
            matrix[i, j] = i + j;
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

int[,] matrixSumInt = CreateMatrixSumInd(3, 4);
PrintMatrix(matrixSumInt);
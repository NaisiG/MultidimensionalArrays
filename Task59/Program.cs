// Задача 59: Задайтедвумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");

    }
}

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRow = 0;
    int indexColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn, min };
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine();
}

int[,] RemoveCrossedRowColumn(int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++) // строка
    {
        if (i == removeRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)  // столбец
        {
            if (j == removeColumn) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);

int[] indexMinVal = IndexMinVal(firstMatrix);
PrintArray(indexMinVal);
Console.WriteLine(String.Empty);

int[,] cuttedArray = RemoveCrossedRowColumn(firstMatrix, indexMinVal[0], indexMinVal[1]);
PrintMatrix(cuttedArray);
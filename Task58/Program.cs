// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int matrixRows1 = matrix1.GetLength(0);
    int matrixCol1 = matrix1.GetLength(1);
    int matrixRows2 = matrix2.GetLength(0);
    int matrixCol2 = matrix2.GetLength(1);
    int[,] matrix3 = new int[matrixRows1, matrixCol2];
    if (matrixCol1 != matrixRows2)
    {
        Console.WriteLine("Неверная размерность матриц");  
        Console.WriteLine();      
    }
    
    else
    {
        
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(1); k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
        }
        
    }  
    return matrix3;      
}



int[,] firstMatrix = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);
int[,] secondMatrix = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(secondMatrix);
Console.WriteLine(String.Empty);
int[,] divMatrix = DivMatrix(firstMatrix, secondMatrix);
PrintMatrix(divMatrix);
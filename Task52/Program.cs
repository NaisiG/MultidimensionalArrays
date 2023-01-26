// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void FindSumInd(int[,] matrix)
{     
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j  < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}; ");                
    }    
    Console.ReadLine();   
}


int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
FindSumInd(array2D);

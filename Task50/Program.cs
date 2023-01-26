// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");

    }
}

void GetValue(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int rows = Convert.ToInt32(Console.ReadLine()) -1;
    Console.Write("Введите номер столбца: ");
    int columns = Convert.ToInt32(Console.ReadLine()) -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (rows < 0 | rows > matrix.GetLength(0) -1 | columns < 0 | columns > matrix.GetLength(1) -1)
            {
                Console.WriteLine("Элемент не существует  ");
                break;
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", matrix[rows, columns]);
                break;
            }
            Console.WriteLine();
        }
    }
}



int[,] matrix2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix2D);
Console.WriteLine();
GetValue(matrix2D);






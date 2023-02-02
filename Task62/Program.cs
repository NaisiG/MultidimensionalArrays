int n = 5;
int[,] matrix3 = new int[n, n];
int num = 1;
int delta = 0;
int beta = matrix3.GetLength(0) - 1;
int var = matrix3.GetLength(0) - 1;

while(beta >= delta )
{
    for(int i = 0 + delta; i < beta; i++)
    {
        matrix3[0 + delta,i] = num;
        num++;
    }
    
    for(int i = 0 + delta; i < beta; i++)
    {
        matrix3[i,var - delta] = num;
        num++;
    }
    
    for(int i = 0 + beta; i >= delta; i--)
    {
        matrix3[var - delta,i] = num;
        num++;
    }
    
    num--;
    for(int i = 0 + beta; i >= delta + 1; i--)
    {
        matrix3[i,0 + delta] = num;
        num++;
    }

    delta++;
    beta--;
    
    
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
PrintMatrix(matrix3);
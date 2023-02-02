// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите натуральное число M: ");
int nNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int mNum = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(nNum, mNum);

void NaturalNumbersRange(int nNum, int mNum)
{
    if(nNum ==mNum) Console.Write($"{nNum} ");
    else if (nNum < mNum)
    {   
        Console.Write($"{nNum} ");     
        NaturalNumbersRange(nNum + 1, mNum);        
    }
    else 
    {
        Console.Write($"{nNum} ");
        NaturalNumbersRange(nNum - 1, mNum);        
    }
}
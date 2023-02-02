using System.ComponentModel.Design;
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int mNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int nNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(mNum, nNum));

int SumNumbers(int mNum, int nNum)
{
    if(mNum == nNum) return mNum;
    if(mNum > nNum) return 
    nNum + SumNumbers(mNum, nNum + 1);
    return mNum + SumNumbers(mNum + 1, nNum);          
}
 


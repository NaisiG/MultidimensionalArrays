// Задача 67: Напишите программу, 
//которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число от двухзначного: ");
int numumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FacSumDigits(numumber));

int FacSumDigits(int num)
{
    if (num == 0) return num;
    else return num % 10 + FacSumDigits(num / 10);
}

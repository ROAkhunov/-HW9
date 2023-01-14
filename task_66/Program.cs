// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumb(int leftRange, int rightRange)
{
    if (leftRange==rightRange) return rightRange;
    return leftRange + SumNumb(leftRange+1,rightRange);
}
Console.WriteLine("Введите левую границу: ");
int leftRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу: ");
int rightRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {leftRange} до {rightRange} равна {SumNumb(leftRange,rightRange)}");
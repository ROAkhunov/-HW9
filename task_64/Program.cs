// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumber(int start, int end)
{
    if (end==start) return end.ToString();
   return (end +", "+PrintNumber(start,end-1));
}
Console.WriteLine("Введите число: ");
int rightRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(1,rightRange));
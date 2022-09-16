/* Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine();
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
int count = 2;

Console.Write($"{num} -> ");
if (num < 2) Console.Write("value less than 2");
if (div != 0) num = num - 1;
if (num >= 2) Console.Write(count);

while (num > count)
{
    count += 2;
    Console.Write($", {count}");
}
Console.WriteLine("\n");

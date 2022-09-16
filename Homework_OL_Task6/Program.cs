/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine();
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
//Console.WriteLine(div);

if (div == 0) 
{Console.WriteLine($"Number {num} -> yes (even) \n");}
else
Console.WriteLine($"Number {num} -> no (odd) \n");

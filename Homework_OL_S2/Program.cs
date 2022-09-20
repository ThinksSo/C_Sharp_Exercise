/* Seminar2 Homework
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да; 7 -> да; 1 -> нет
*/


Console.Write("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

void Task10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
    // и на выходе показывает вторую цифру этого числа.
    // 456 -> 5; 782 -> 8; 918 -> 1

    Console.WriteLine("\n Task 10");

    if (num < 100) Console. WriteLine("invalid input");
    else
    {
        int result = (num/10)%10;
        Console.WriteLine($"{num} -> {result}"); 
    }
}

Task10();

void Task13()
{
    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
    // или сообщает, что третьей цифры нет.
    // 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

    Console.WriteLine("\n Task 13");
    
    if (num < 100) Console. WriteLine($"{num} -> no third digit");
    else
    {
        int third = num%10;
        Console.WriteLine($"{num} -> {third}"); 
    }
}

Task13();
Console.WriteLine();

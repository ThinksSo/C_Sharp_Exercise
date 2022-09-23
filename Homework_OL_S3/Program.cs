/*
Задача 19 Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет, 12821 -> да, 23432 -> да
*/

int Rev(int num)
{
    int digit = 0, rev = 0;

    while(num > 0)
    {
        digit = num % 10;
        rev = rev * 10 + digit;
        num = num /10;
    }
    return rev;
}


void Task19() 
{
    Console.WriteLine("\n \t Task 19: Palindrome check");
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 9999 && number < 100000)
    {
        int reversed = Rev(number);
        if (number == reversed) Console.WriteLine($"Yes, {number} - palindrome");
        else Console.WriteLine($"{number} - Not palindrome");
    }
    else Console.WriteLine("Invalid input");
}

Task19();
Console.WriteLine();


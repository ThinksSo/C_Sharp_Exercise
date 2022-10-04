// Урок 6. Двумерные массивы и рекурсия

/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
*/
void Task41()
{
    Console.WriteLine("\n \t Task 41: Numbers > 0");
    Console.Write("How many numbers do you want to enter?: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter a number {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) sum++;
        numbers[i] = num;
    }
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine($"numbers > 0 -> {sum} \n");
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void Task43()
{
    Console.WriteLine("\n \t Task 43: Crossing lines");
    Console.Write("Enter b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);

    Console.WriteLine($"\n y = {k1}x + {b1}, y = {k2}x + {b2}");
    Console.WriteLine($" ->  (x, y) = ({x}; {y}) \n");
}


void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Task41();
Task43();

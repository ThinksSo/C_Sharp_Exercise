// Урок 7. Как не нужно писать код. Часть 1
Console.Clear();

/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами, округлёнными до одного знака.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
void Task47()
{
    Console.WriteLine("\n \t Task 47: Array mxn");
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[rows, columns];

    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
}

void FillArrayDouble(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round((random.Next(-10, 50) + random.NextDouble()), 1);
        }
    }
}

void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}  \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


/* Задача 50: Напишите программу, которая на вход принимает индексы элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
void Task50()
{
    Console.WriteLine("\n \t Task 50: Check number in 2хArray");
    Random random = new Random();
    int rows = random.Next(2, 10);
    int columns = random.Next(3, 9);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);

    Console.Write("Enter index of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter index of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    PrintArray(numbers);
    if (m < rows && n < columns) Console.WriteLine($"index ({m}, {n}) = {numbers[m, n]}");
    else Console.WriteLine($"index {m}, {n} outside of the array");

    Console.WriteLine();
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}  \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/* Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Task52()
{
    Console.WriteLine("\n \t Task 52: Average columns in 2хArray \n");
    Random random = new Random();
    int rows = random.Next(2, 8);
    int columns = random.Next(3, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < columns; i++)
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < rows; j++)
        {
            sum = sum + numbers[j, i];
            count++;
        }
        double average = Math.Round((sum / count), 2);
        Console.WriteLine($"Average columns {i + 1} = {average}");
    }
    Console.WriteLine();
}


Task47();
Task50();
Task52();


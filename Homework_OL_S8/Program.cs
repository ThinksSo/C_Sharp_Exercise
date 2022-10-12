/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Task54()
{
    Console.WriteLine("\n \t Task 54: 2xArray: sorting rows descending \n");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine();
}

/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
void Task56()
{
    Console.WriteLine("\n \t Task 56: 2xArray: min summ row \n");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int minRowSum = SumRowArray(numbers, 0);
    Console.WriteLine($" Row {1} sum \t = {minRowSum}");
    int indexMinRow = 0;

    for (int i = 1; i < rows; i++)
    {
        int sum = SumRowArray(numbers, i);
        if (minRowSum > sum)
        {
            minRowSum = sum;
            indexMinRow = i;
        }
        Console.WriteLine($" Row {i + 1} sum \t = {sum}");
    }
    Console.WriteLine($"\n Min sum in row {indexMinRow + 1} = {minRowSum}");
    Console.WriteLine();
}

int SumRowArray(int[,] numbers, int rowIndex = 0)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int rowSum = 0;

    for (int j = 0; j < columns; j++)
    {
        rowSum += numbers[rowIndex, j];
    }
    return rowSum;
}


/* Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Task58()
{
    Console.WriteLine("\n \t Task 58: Spiral array\n");
    int size = 4;
    int[,] spiral = new int[size, size];

    FillArraySpiral(spiral);
    PrintArray(spiral);
}

void FillArraySpiral(int[,] numbers)
{
    int n = numbers.GetLength(0);
    int num = 1;

    for (int i = 0; i <= n / 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            numbers[i, j] = num++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            numbers[k, n - 1 - i] = num++;
        }
        for (int j = n - 1 - i; j > i; j--)
        {
            numbers[n - i - 1, j - 1] = num++;
        }
        for (int k = n - 2 - i; k > i; k--)
        {
            numbers[k, i] = num++;
        }
    }

}


// Задача 61: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
void Task61()
{
    Console.WriteLine("\n \t Task 61: Matrix multiplication \n");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;

    int[,] numbers1 = new int[rows, columns];
    FillArray(numbers1);
    int[,] numbers2 = new int[rows, columns];
    FillArray(numbers2);

    int n = numbers1.GetLength(0);
    int[,] result = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                result[i, j] += numbers1[i, k] * numbers2[k, j];
            }

        }
    }
    Console.WriteLine("Matrix 1:");
    PrintArray(numbers1);
    Console.WriteLine("Matrix 2:");
    PrintArray(numbers2);
    Console.WriteLine("Matrix multiplication:");
    PrintArray(result);
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
            Console.Write($"{numbers[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Task54();
Task56();
Task58();
Task61();

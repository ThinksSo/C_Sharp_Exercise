/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void Task34()
{
    Console.WriteLine("\n \t Task 34");
    Random random = new Random();
    int size = random.Next(2, 15);

    int[] numbers = new int[size];
    int minArg = 100, maxArg = 999;

    CLib.Array.FillArray(numbers, minArg, maxArg);

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    CLib.Array.PrintArray(numbers);
    Console.WriteLine("Even numbers -> " + count);
}

/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
*/

void Task36()
{
    Console.WriteLine("\n \t Task 36");
    Random random = new Random();
    int size = random.Next(2, 15);
    int[] numbers = new int[size];
    int minArg = -100, maxArg = 100;

    CLib.Array.FillArray(numbers, minArg, maxArg);

    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum = sum + numbers[i];
    }

    CLib.Array.PrintArray(numbers);
    Console.WriteLine("Sum with odd index -> " + sum);
    Console.WriteLine();
}

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
void Task38()
{
    Console.WriteLine("\n \t Task 38");

    Random random = new Random();
    int size = random.Next(2, 10);
    double[] numbers = new double[size];
    
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = Math.Round(random.Next(-10, 100) + random.NextDouble(), 2);
        Console.Write(numbers[i] + " ");
    }
    
    //for (int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
    
    double max = numbers[0];
    double min = numbers[0];
    for (int j = 0; j < numbers.Length-1; j++) 
    {
        if (numbers[j] < numbers[j+1]) max = numbers[j+1];
        if (numbers[j] > numbers[j+1]) min = numbers[j+1];
    }
    Console.WriteLine($"\n Min - Max = {max} - {min} = {Math.Round(max - min, 2)}");

    Console.WriteLine();

}



Task34();
Task36();
Task38();



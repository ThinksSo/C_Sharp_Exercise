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
    Console.WriteLine("-> " + count);



}

Task34();

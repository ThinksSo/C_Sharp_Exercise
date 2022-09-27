/* Урок 4. Функции продолжение
Задача 25: Используя определение степени числа, напишите цикл, 
который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3⁵), 2, 4 -> 16
*/
void Task25()
{
    Console.WriteLine("\n \t Task 25: Numbers to power");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter degree: ");
    int degree = Convert.ToInt32(Console.ReadLine());
    int result = num;

    for (int i = 1; i < degree; i++)
    {
        result = result * num;
    }
    Console.WriteLine($"{num} ^ {degree} = {result}");
}


/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11; 82 -> 10; 9012 -> 12
*/
void Task27()
{
    Console.WriteLine("\n \t Task 27: Numbers sum");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int reduct = Math.Abs(num);
    int sum = 0;

    while (reduct > 0)
    {
        int div = reduct % 10;
        sum = sum + div;
        reduct = reduct / 10;
    }
    Console.WriteLine($"{num} -> {sum}");
}


/*Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] ; 6, 1, -33 -> [1, 6, -33]
*/
void Task29()
{
    Console.WriteLine("\n \t Task 29: Sort array");
    int size = 8;    
    int[] numbers = new int[size];

    FillArray(numbers, size);
    ArraySort(numbers);
    PrintArray(numbers);
}

void FillArray (int[] num, int lenght)
{
    Random random = new Random();
    for (int i = 0; i < lenght - 1; i++)
    {
        num[i] = random.Next(-100,100);
        Console.Write(num[i] + " ");
    } 
}

void ArraySort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Task25();
Task27();
Task29();

Console.WriteLine();

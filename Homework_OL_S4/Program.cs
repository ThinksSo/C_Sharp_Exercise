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

Task25();


/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11; 82 -> 10; 9012 -> 12
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] 
6, 1, -33 -> [1, 6, -33]
*/


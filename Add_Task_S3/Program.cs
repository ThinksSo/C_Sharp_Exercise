// Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, 
// где n задаётся случайно от 2 до 100.

void Task8()
{
    Random random = new Random();
    int num = random.Next(2, 100);
    int count = 2;

    while (count < num+1)
    {
        for (int i=1; i <= num; i++)
        {
            Console.WriteLine($"{count} * {i} = {i * count}");
        }
        Console.WriteLine();
        count++;
    }
}


/* Задача 9. Дана игра со следующими правилами. 
Первый игрок называет любое натуральное число от 2 до 9, 
второй умножает его на любое натуральное число от 2 до 9, 
первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
Выигрывает тот, у кого впервые получится число больше 1000. 
Запрограммировать консольный вариант игры.
*/
void Task9()
{
    Console.WriteLine();
    int result = 1;
    int min = 2, max = 9;
    while (result < 1000)
    {
        Console.Write("Player 1. Enter a number from 1 to 9: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        while (num1 < min || num1 > max)
        {
            Console.Write("Invalid input. Player 1. Re-enter the number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"{result} * {num1} = {result * num1}");
        result = result * num1;
        if (result >= 1000) Console.WriteLine($"\n Player 1 Win!");
        else
        {
            Console.Write("Player 2. Enter a number from 1 to 9: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num2 < min || num2 > max)
            {
                Console.Write("Invalid input. Player 2. Re-enter the number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"{result} * {num2} = {result * num2}");
            result = result * num2;
            if (result >= 1000) Console.WriteLine($"\n Player 2 Win!"); 
        }  
        Console.WriteLine();
    }

}


// Task8();
Task9();


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

/*
Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84: A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Task21()
{
    Console.WriteLine("\n \t Task 21: Line lenght in 3D");
    Console.Write("Enter A(x): "); int xA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter A(y): "); int yA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter A(z): "); int zA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter B(x): "); int xB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter B(y): "); int yB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter B(z): "); int zB = Convert.ToInt32(Console.ReadLine());


    double lenght = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
    Console.WriteLine($" A({xA}, {yA}, {zA}); B({xB}, {yB}, {zB}) lenght = {lenght}) ");


}

 // Option II
void Task21_2()
{
    Console.WriteLine("\n \t Task 21 - 2: Random line lenght in 3D");
   
    Random random = new Random();
    int xA = random.Next(0, 100), yA = random.Next(0, 100), zA = random.Next(0, 100),
    xB = random.Next(0, 100), yB = random.Next(0, 100), zB = random.Next(0, 100);

    double lenght = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
    Console.WriteLine($" A({xA}, {yA}, {zA}); B({xB}, {yB}, {zB}) lenght = {lenght}) ");
}



/*
Задача 23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
*/

Task19();
Task21();
Task21_2();
Console.WriteLine();


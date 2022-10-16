/* Задача 64: Задайте значения M и N. 
Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"
M = 13; N = 20. -> "15, 18"
*/
void Task65()
{
    Console.WriteLine("\n \t Task 65: Number range n - m");
    Console.Write("Enter first number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter last number: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int mult = 3;

    // цикл
    for (int i = n; i <= m; i++)
    {
        if (i % mult == 0) Console.Write(i + " ");
    }
    Console.WriteLine();

    // рекурсия
    RangeMult(m, n, mult);

    Console.WriteLine("\n");
}


void RangeMult(int number, int counter = 0, int multiple = 1)
{
    if (counter % multiple == 0) Console.Write($"{counter} ");
    if (counter == number) return;
    counter++;
    RangeMult(number, counter, multiple);
}


/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void Task66()
{
    Console.WriteLine("\n \t Task 66: Sum numbers in range");
    Console.Write("Enter first number: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter last number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // рекурсия
    Console.WriteLine($"Sum of range numbers {m}...{n} = {SumRange(n, m)}");

    //цикл
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Sum of range numbers {m}...{n} = {sum} \n");

}

int SumRange(int n, int m = 0)
{
    if (m == n) return n;
    else return n + SumRange(n - 1, m);
}


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
void Task68()
{
    Console.WriteLine("\n \t Task 66: Ackerman function");
    Console.Write("Enter first number: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{Ackerman(m, n)} \n");

}

int Ackerman(int m, int n = 1)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Ackerman(m - 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}


Task65();
Task66();
Task68();

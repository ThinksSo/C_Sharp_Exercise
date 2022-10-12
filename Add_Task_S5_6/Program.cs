
// SEMINAR 5

/* Задача 1. Задан массив из случайных цифр на 15 элементов. 
На вход подаётся трёхзначное натуральное число. 
Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, 
совпадающая с введённым числом.
{0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
{4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет
*/
void Task5_1()
{
    Console.WriteLine("\n \t Task 1: Check sequence in array");
    Console.Write($"Enter a number: ");
    int nummber = Convert.ToInt32(Console.ReadLine());
    int hundreds = nummber / 100;
    int ten = nummber / 10 % 10;
    int digit = nummber % 100 % 10;
    int size = 15;
    bool check = false;

    int[] numbers = new int[size];
    int minValue = 1;
    int maxValue = 4;
    CLib.Array.FillArray(numbers, minValue, maxValue);
    
    for (int i = 0; i < size-2; i++)
    {
        if (numbers[i] == hundreds
            && numbers[i+1] == ten
            && numbers[i+2] == digit)
            check = true;
    }
    if (check) Console.Write($"Yes, {hundreds}; {ten}; {digit} is in \t");
    else Console.Write($"No, {hundreds}; {ten}; {digit} not in \t");
    CLib.Array.PrintArray(numbers);
    Console.WriteLine();
}

// SEMINAR 6
// Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.
void Task6_1()
{
    
}



/* Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
*/
void Task6_2()
{
    Console.WriteLine("\n \t Task 2: Counting letters in an array");
    string phrase = "Без труда не вытащишь рыбку из пруда";
    Console.WriteLine(phrase);
    char[] alphabet = {'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'};
   
    // int count = 0;
    // foreach (char letter in phrase)
    // {
    //     bool contain = alphabet.Contains(letter);
    //     if (contain) count++;
    //     // Console.WriteLine($"Буква: {letter}, гласная: {alphabet.Contains(letter)}");
    // }
    // Console.WriteLine($"В поговорке {count} гласных букв \n");
    Console.WriteLine($"В поговорке {CountLetters(phrase, alphabet)} гласных букв \n");
}

// counting letters in an array (recursion) - счет букв в массиве (рекурсия)
int CountLetters(
                string phrase,
                char[] alphabet,
                int count = 0,
                int index = 0) 
{
    if (index == phrase.Length) return count;
    bool contain = alphabet.Contains(phrase[index]);
    if (contain) count++;
    index++;
    return CountLetters(phrase, alphabet, count, index);
}


Task5_1();
Task6_2();

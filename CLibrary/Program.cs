namespace CLib
{
    class Array
    {
        // Array filling - Заполнение массива
        public static void FillArray(int[] numbers,
                                    int minValue = 0,
                                    int maxValue = 100)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }

        // Array sorting - сортировка массива (пузырьковая)
        public static void SortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }

            }
        }


        // Array print - вывод массива в консоль
        public static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}


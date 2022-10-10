// SEMINAR 7
/* Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами. 
Игрок может ходить только по полям, заполненным единицами. 
Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] 
(эти поля требуется принудительно задать равными единице).
*/
// void Task3()

Console.WriteLine("\n \t Task 3: 2xArray: 5x5 labyrinth");
var random = new Random();
int rows = 10;
int columns = 10;

int[,] map = new int[rows, columns];
FillArray(map, 0, 1);
int max_i = rows - 1;
int max_j = columns - 1;
map[0, 0] = 1;
map[max_i, max_j] = 1;
PrintArray(map);
bool exit = false;
FindPath(map);

if (exit) Console.WriteLine("Exit found");
else Console.WriteLine("NO Exit");
Console.WriteLine();

while (!exit)
{
    FillArray(map, 0, 1);
    FindPath(map);
}
PrintArray(map);

void FindPath(int[,] map, int i = 0, int j = 0)
{
    if (i < 0 || i > max_i
        || j < 0 || j > max_j
        || map[i, j] == 0 || map[i, j] == 2)
    {
        return;
    }

    if (i == max_i && j == max_j)
    {
        exit = true;
        return;
    }
    map[i, j] = 2;
    FindPath(map, i + 1, j);
    FindPath(map, i - 1, j);
    FindPath(map, i, j + 1);
    FindPath(map, i, j - 1);
    FindPath(map, i + 1, j + 1);
    FindPath(map, i - 1, j - 1);
    FindPath(map, i + 1, j - 1);
    FindPath(map, i - 1, j + 1);
}


void FillArray(int[,] numbers, int min, int max)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(min, max + 1);
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
            Console.Write($"{numbers[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



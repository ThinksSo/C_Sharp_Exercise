void Test4Lib()
{
    int size = 10;
    int[] newArr = new int [size];
    int minArg = -10;
    int maxArg = 10;

    CLib.Array.FillArray(newArr, minArg, maxArg);
    CLib.Array.PrintArray(newArr);
    CLib.Array.SortArray(newArr);
    CLib.Array.PrintArray(newArr);
    Console.WriteLine();
}

Test4Lib();

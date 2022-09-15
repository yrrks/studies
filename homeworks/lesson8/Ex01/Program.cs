int[,] Array2D = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
void FindMinLine(int[,] array)
{
    int sizeLine = array.GetLength(1);
    int sizeColumn = array.GetLength(0);
    int minLine = 0;
    int numLine = 1;
    for (int i = 0; i < sizeLine; i++)
    {
        minLine = minLine + array[0, i];
    }
    for (int j = 0; j < sizeColumn; j++)
    {
        int comparison = 0;
        for (int m = 0; m < sizeLine; m++)
        {
            comparison = comparison + array[j, m];
        }
        if (comparison < minLine)
        {
            minLine = comparison;

        }
    }
    Console.WriteLine($"{numLine} строка минимальная со значением {minLine}");
}
FindMinLine(Array2D);
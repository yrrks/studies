float[,] Array2D = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
void AverageColumn(float[,] Array)
{
    int sizeColumn = Array.GetLength(1);
    int sizeLine = Array.GetLength(0);
    for (int i = 0; i < sizeColumn; i++)
    {
        float averageCol = 0;
        float summ = 0;

        for (int j = 0; j < sizeLine; j++)
        {
            summ = summ + Array[j, i];
        }
        averageCol = summ / sizeLine;
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {averageCol}");
    }
}
AverageColumn(Array2D);
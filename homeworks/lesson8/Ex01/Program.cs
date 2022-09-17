int[,] Array2D = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
void SortArray(int[,] array)
{
    int sizeLine = array.GetLength(1) - 1;
    int sizeColumn = array.GetLength(0) - 1;
    for (int i = 0; i < sizeLine; i++)
    {
        for (int j = 0; j <= sizeColumn; j++)
        {
            for (int m = 1; m <= sizeLine; m++)
            {

                if (array[j, m] > array[j, m - 1])
                {
                    int change = array[j, m];
                    array[j, m] = array[j, m - 1];
                    array[j, m - 1] = change;
                    change = 0;

                }
            }
        }
    }
}

SortArray(Array2D);
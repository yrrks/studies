int[,,] Array3D = { { { 66, 27 }, { 25, 90 } }, { { 34, 26 }, { 41, 55 } } };
void ShowArray(int[,,] array)
{
    int arrayX = array.GetLength(0);
    int arrayY = array.GetLength(1);
    int arrayZ = array.GetLength(2);
    for (int i = 0; i < arrayZ; i++)
    {
        for (int j = 0; j < arrayY; j++)
        {
            Console.WriteLine(" ");
            for (int m = 0; m < arrayX; m++)
            {
                int number = array[j, m, i];
                Console.Write($"{number}({j},{m},{i}) ");
            }
        }
    }
}
ShowArray(Array3D);
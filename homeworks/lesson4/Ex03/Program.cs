int[] array = new int[8];
void filling(int[] massiv)
{
    int size = massiv.Length;
    for (int i = 0; i < size; i++)
    {
        Random rand = new Random();
        massiv[i] = rand.Next(1, 10);

    }
}
filling(array);
Console.WriteLine(String.Join(" ", array));
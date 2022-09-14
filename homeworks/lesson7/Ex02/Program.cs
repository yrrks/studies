int m = 3;
int n = 4;
double[,] Array2D = new double[m, n];
void FillArray(double[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            Array[i, j] = Convert.ToDouble(rand.Next(-100, 100));
        }
    }
}

void ShowPosition(double[,] ShowArray)
{
    Console.WriteLine("Введите номер строки: ");
    int line = (Convert.ToInt32(Console.ReadLine()) - 1);
    Console.WriteLine("Введите номер столбца: ");
    int column = (Convert.ToInt32(Console.ReadLine()) - 1);

    if (column > n || line > m)
    {
        Console.WriteLine("Эллемента с таким индексом нет.");

    }
    else { Console.WriteLine($"Эллемент масива с индексом[{line + 1} {column + 1}] = {ShowArray[line, column]}"); }
}
FillArray(Array2D);
ShowPosition(Array2D);
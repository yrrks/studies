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
FillArray(Array2D);

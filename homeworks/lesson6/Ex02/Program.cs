(double x1, double y1)[] pos1 = new (double, double)[100];
(double x2, double y2)[] pos2 = new (double, double)[100];
int ArrayLength1 = pos1.Length;
int ArrayLength2 = pos2.Length;
void SolutionFunc1((double, double)[] Array)
{
    for (int count = 0; count < ArrayLength1; count++)
    {
        double x1 = -5;
        double b1 = 2;
        double k1 = 5;
        double y1 = k1 * x1 + b1;
        Array[count] = (x1, y1);
        x1 = Convert.ToDouble(0.1);

    }
}
void SolutionFunc2((double, double)[] Array)
{
    for (int count = 0; count < ArrayLength2; count++)
    {
        double x2 = -5;
        double b2 = 4;
        double k2 = 9;
        double y2 = k2 * x2 + b2;
        Array[count] = (x2, y2);
        x2 = x2 + Convert.ToDouble(0.1);

    }
}

void FindIntersection((double, double)[] Array1, (double, double)[] Array2)
{
    for (int i = 0; i < ArrayLength1; i++)
    {
        if (Array1[i] == Array2[i])
        {
            Console.WriteLine($"Пересечение прмяых находится в точке {Array1[i]}");
        }
        else
        {
            Console.WriteLine("Не найдено!");
        }
    }
}



SolutionFunc1(pos1);
SolutionFunc2(pos2);
FindIntersection(pos1, pos2);
Console.WriteLine(pos1[5]);
double[] Array = { 3, 7, 22, 2, 78 };
double max = Array[1];
double min = Array[1];
int ArrayLength = Array.Length;
void MinimalNum(double[] MinArray)
{
    for (int i = 1; i < ArrayLength; i++)
    {
        if (MinArray[i] < min)
        {
            min = MinArray[i];
        }
        else { }
    }
}
void MaximalNum(double[] MaxArray)
{
    for (int i = 1; i < ArrayLength; i++)
    {
        if (MaxArray[i] > max)
        {
            max = MaxArray[i];
        }
        else { }
    }
}
MinimalNum(Array);
MaximalNum(Array);
double result = max - min;
Console.WriteLine($"Разница между наибольшим и наименьшим эллементами массива = {result}");
int[] Array = new int[4];
int ArrayLength = Array.Length;

void RandArray(int[] Massiv)
{
    Random rand = new Random();
    for (int i = 0; i < ArrayLength; i++)
    {
        Massiv[i] = rand.Next(1, 10);
    }
}
void SumPos(int[] SummArray)
{
    int sum = 0;
    for (int i = 0; i < ArrayLength; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + SummArray[i]; // Это если мы считает массив с 1ого эллемента
                                      // если с 0 - в елсе переносим эту строчку
        }
        else
        {

        }
    }
    Console.WriteLine(String.Join(" ", Array));
    Console.WriteLine($"Сумма эл. на нечетных позициях ={sum}");
}
RandArray(Array);
SumPos(Array);
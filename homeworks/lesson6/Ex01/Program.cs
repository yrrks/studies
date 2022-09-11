int count = 0;
void PositiveNumber(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите любое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;

        }
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}
Console.WriteLine("Введите количество чисел которые собираетесь вводить: ");
int amount = Convert.ToInt32(Console.ReadLine());
PositiveNumber(amount);

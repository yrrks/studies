int m = 1;
int n = 5;
void ShowNumbsNatural(int start, int end)
{
    for (int i = start + 1; i < end; i++)
    {
        Console.Write($"{i} ");
    }
}
ShowNumbsNatural(m, n);
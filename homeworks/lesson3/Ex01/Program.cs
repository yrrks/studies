void ItPalindrom(string num)
{
    int len = num.Length;
    if (len == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        
            {
                Console.WriteLine("Палиндром!");
            }
            else Console.WriteLine("Не палиндром(");
       
    }
    else Console.WriteLine("не пятизначное число(");
}

Console.WriteLine("Введите пятизначное число: ");
string? input = (Console.ReadLine());
ItPalindrom(input!);
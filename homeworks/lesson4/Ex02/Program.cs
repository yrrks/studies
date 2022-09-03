Console.WriteLine("Введите число :");
string number = Console.ReadLine();
int size = number.Length;
double sum = 0;
for (int i = 0; i < size; i++)
{
    string str = Convert.ToString(number[i]);
    int add = Convert.ToInt32(str);
    sum = sum + add;

}

Console.WriteLine($"сумма цифр в числе = {sum}");


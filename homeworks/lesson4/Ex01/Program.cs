Console.WriteLine("Введите число :");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите факториал :");
int numB = int.Parse(Console.ReadLine());
int multi = numA;
void factorial(int num1, int num2)
{
    for (int i = 1; i < num2; i++)
    {

        num1 = num1 * multi;
    }
    Console.WriteLine(num1);
}
factorial(numA, numB);
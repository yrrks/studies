int num = 326;
void Method(int number) {
string num1 = Convert.ToString(number);
int len = num1.Length;
if (len >= 2) {
    Console.WriteLine(num1[2]);
}
else Console.WriteLine("короткое число");
}
Method(num);
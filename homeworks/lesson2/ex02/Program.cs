int num = 32679;
string num1 = Convert.ToString(num);
int len = num1.Length;
if (len > 3) {
    Console.WriteLine(num1[2]);
}
else Console.WriteLine("короткое число");

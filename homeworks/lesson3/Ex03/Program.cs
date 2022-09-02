Console.WriteLine("Введите число: ");
int input = int.Parse(Console.ReadLine());


void CubMethod(int num){
for(int i = 1; i <= num; i++ ) {
    Console.WriteLine($"квадрат числа {i} = {i * i}");
}
}

CubMethod(input);
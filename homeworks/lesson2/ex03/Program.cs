int[] week = new int[] {0,0,0,0,0,1,1};

void Method(int[] array) {
Console.WriteLine("Введите номер дня недели: ");
string? day = Console.ReadLine();
int int_day = Convert.ToInt32(day);
int_day = int_day - 1;

if (array[int_day] == 1) {
    Console.WriteLine("Выходной!");
}
else {
    Console.WriteLine("Рабочий день(((");

}
}
Method(week);
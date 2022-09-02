Console.WriteLine("Введите х1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите х2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine()!);
double[] dat = new double[] {x1,x2,y1,y2,z1,z2};
void Method(double[] cor){
    double m = 0;
    m = Math.Abs((cor[1] - cor[0]) + (cor[3] - cor[2]) + (cor[5] - cor[4]));
    double  distance = Math.Sqrt(m);
    double end = distance;
    Console.WriteLine(end);

}
Method(dat);
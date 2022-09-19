double a = 2;
double b = 3;
double A(double m, double n){
    if(m < 0 || n < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, m);
    return A(n - 1, A(n, m - 1));
    
}
Console.WriteLine(String.Join(" ",A(a,b)));
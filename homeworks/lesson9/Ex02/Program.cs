int m = 1;
int n = 15;
void SummNatrural(int start, int end){
    int summ = 1;
    for(int i = start + 1; i <= end; i++){
        
        summ = summ +i;
        
    }
    Console.WriteLine(summ);
}
SummNatrural(m, n);
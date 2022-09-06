int[] array = new int[10];
int size = array.Length;
int count = 0;
void zapolnenie(int[] massiv)

{
    for (int i = 0; i < size; i++)
    {
        Random rand = new Random();
        massiv[i] = rand.Next(100, 999);
    }
}
void honest(int[] masiv)

{
    for(int i = 0; i < size; i++){
        if(masiv[i] % 2 == 0){
            count++;
        }
    
    else{}
        
       
        
    }
    Console.WriteLine($"Количество четных чисел : {count}");
    
}
zapolnenie(array);
honest(array);

Console.WriteLine(String.Join(" ", array));



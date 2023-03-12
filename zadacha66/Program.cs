int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine()); ;
NaturalNumbers(N, M);

void NaturalNumbers(int m, int n)
{
    
    if(m < n)  return;
    {
        Console.Write($"{n} ");
        NaturalNumbers(m, n + 1);
    }
}


int N = int.Parse(Console.ReadLine());
NaturalNumbers(N);

for(int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
}
void NaturalNumbers(int n)
{
    if(n != 0) return;
    else 
    {
        Console.Write($"{n} ");
        NaturalNumbers(n-1);
    }
}
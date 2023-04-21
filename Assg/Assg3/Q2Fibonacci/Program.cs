//Q2 Fibonacci sequence

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

static int Fibonacci(int nth)
{
    if(nth == 1 || nth == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(nth - 2) + Fibonacci(nth - 1);
    }
}
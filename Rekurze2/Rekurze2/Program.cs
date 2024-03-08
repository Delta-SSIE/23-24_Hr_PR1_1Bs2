int n = 2;
int result = SquareSum(n);
Console.WriteLine("Soucet prvnich n ctvercovych cisel je " + result);
    

    static int SquareSum(int n)
{
    if (n <= 0)
    {
        return 0;
    }
    else
    {
        return n * n + SquareSum(n - 1);
    }
}
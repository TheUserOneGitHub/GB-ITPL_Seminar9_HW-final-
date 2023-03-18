// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FUCNT1(int n, int m, int rev)
{
    if (m > 0 && n == 0)
    {
        Console.WriteLine($"Check n = 0");
        m = m - 1;
        n = 1;
        Console.WriteLine($"m = {m}, n = {n}");
        if (m > 0)
        {
            Console.WriteLine($"n = 0 --> F2");
            FUCNT2(n, m, rev);
        }
        else if (m == 0)
        {
            Console.WriteLine($"n = 0 --> F0");
            FUCNT0(n, m, rev);
        }
    }
    return n;
}

int FUCNT2(int n, int m, int rev)
{
    if (m > 0 && n > 0)
    {
        n = SpecFun(m, n, rev);
        if (m == 0)
        {
            FUCNT0(n, m, rev);
        }
        if (m > 0)
        {
            FUCNT2(n, m, rev);
        }
        m = m - 1;
        rev = m;
    }
    return n;
}

int FUCNT0(int n, int m, int rev)
{
    if (m == 0)
    {
        Console.WriteLine($"Check m = 0");
        n = n + 1;
        Console.WriteLine($"A = {n}");
    }
    if (rev > 0)
    {
        m = rev;
        Console.WriteLine($"rev = {rev}");
        // FUCNT2(n, m, rev);
    }
    return n;
}

int SpecFun(int n, int m, int rev)
{
    Console.WriteLine($"Check SpecFun");
    n = n - 1;
    Console.WriteLine($"m = {m}, n = {n}");
    if (n == 0)
        FUCNT1(n, m, rev);
    if (n > 0)
        FUCNT2(n, m, rev);
    return n;

}



Console.WriteLine("Enter first natural number");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second natural number");
int n = Convert.ToInt32(Console.ReadLine());

int rev = m -1;

FUCNT0(n, m, rev);
FUCNT1(n, m, rev);
// FUCNT2(n, m);
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

void Start(int m, int n, int count)
{
    Console.WriteLine("Enter first natural number");
    m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second natural number");
    n = Convert.ToInt32(Console.ReadLine());
    Check(m, n, count);
}

int Check(int m, int n, int count)
{
    if (m > n)
    {
        Console.WriteLine($"The first natural number must be less than or equal to the second natural number");
        Start(m, n, count);
    }
    else
    {
        Console.WriteLine($" The sum is {SumOfNatNumbs(n, m, count)}");
    }
    return n;
}

int SumOfNatNumbs(int n, int m, int count)
{
    int sum = ((n * n - m * m + n + m) / 1 + count);
    count++;
    if (1 + count < 3)
    {
        SumOfNatNumbs(n, m, count);
    }
    sum = sum / 2;
    return sum;
}





Console.WriteLine("Enter first natural number");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second natural number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

Check(m, n, count);
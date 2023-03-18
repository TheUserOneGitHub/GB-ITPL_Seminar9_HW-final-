// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void Start(int n)
{
    Console.WriteLine("Enter a natural number");
    n = Convert.ToInt32(Console.ReadLine());
    Check(n);
}

int Check(int n)
{
    if (n < 1)
    {
        Start(n);
    }
    else if (n == 1)
    {
        Console.WriteLine($"The series of natural numbers from {n} to 1: 1");
    }
    else
    {
        Console.Write($"The series of natural numbers from {n} to 1: ");

        Console.Write($"{n}, ");

        SerOfNatNumbs(n);
    }
    return n;
}

int SerOfNatNumbs(int n)
{
    n = n - 1;
    Console.Write($"{n}");
    if (n > 1)
    {
        Console.Write($", ");
        SerOfNatNumbs(n);
    }
    return n;
}





Console.WriteLine("Enter a natural number");
int n = Convert.ToInt32(Console.ReadLine());

Check(n);
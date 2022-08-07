Console.WriteLine("введите число, отличное от 0");

try
    {
    double n = Convert.ToDouble(Console.ReadLine());
    if (n > 0)
    {
        n = n - n % 1;
    }
    else
    {
        n = n + -n % 1;
    }
    int m = Convert.ToInt32(n);
    int i = 0 - m;
    if (m > 0)
    {
        while (i < m + 1)
        {
            Console.Write(i);
            Console.Write(" ");
            i = i + 1;
        }
    }
    else
    {
        i = 0 - i;
        while (i < -m + 1)
        {
            Console.Write(i);
            Console.Write(" ");
            i = i + 1;
        }
    }
    }
catch
    {
    Console.WriteLine("ты читать не умеешь? Короче, введи ЦЕЛОЕ число не равное 0");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 0)
    {
        n = 0 - n;
    }
    for (int i = -n; i <= n; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
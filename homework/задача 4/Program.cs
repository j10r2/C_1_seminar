Console.WriteLine("Введите число");
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
if (a >= 2 | a <= 0)
    {
    if (a > 0)
        {
        for (int i = 2; i <= a; i+=2)
            {
            Console.Write(i + ", ");
            }
        }
    else
        {
        for (int i = 0; i >= a; i-=2)
            {
            Console.Write(i + " ");
            } 
        }
    }
else
    {
        Console.WriteLine("Нет подходящих чисел для вывода");
    }

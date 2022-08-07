Console.WriteLine("Введите любое число");
try
{
    double a = double.Parse(Console.ReadLine());
    if (a %2 == 0)
    Console.WriteLine("Введённое число чётное");
    else
    {
        Console.WriteLine("Введённое число нечётное");
    }
}
catch (System.Exception)
{
    Console.WriteLine("Это было не число (-_-). Попробуй ещё раз.");
    try
    {
       double a = double.Parse(Console.ReadLine());
    if (a %2 == 0)
    Console.WriteLine("Введённое число чётное");
    else
    {
        Console.WriteLine("Введённое число нечётное");
    }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Попытки закончились.");   
    }
    
}


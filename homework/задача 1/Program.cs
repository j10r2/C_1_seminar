Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine());

Console.WriteLine();

if (a > b)
{
    Console.WriteLine(a + " больше, чем " + b);
}
else
{
    Console.WriteLine(b + " больше, чем " + a);
}
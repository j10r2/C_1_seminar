Console.WriteLine("введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите второе число");
double b = Convert.ToDouble(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
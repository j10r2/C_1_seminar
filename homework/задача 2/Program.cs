Console.WriteLine("сколько чисел сравниваем?");
try
{
int size = int.Parse(Console.ReadLine());
if (size < 1)
{
    Console.WriteLine("хорошая шутка, сравнивать надо минимум 2 числа, попробуй ещё раз:");
    size = int.Parse(Console.ReadLine());
}
if (size > 10)
{
    Console.WriteLine("А ты не устанешь числа придумывать? Давай ещё раз:");
    size = int.Parse(Console.ReadLine());
    if (size > 10)
    {
        size = 10;
        Console.WriteLine("Короче, сравниваем 10.");
    }
}
double [] arr;
arr = new double [size];
double max = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine("введите " + (i+1) + "-е число");
    arr [i] = double.Parse(Console.ReadLine());
    if (arr[i] > max)
    {
        max = arr [i];
    }
}
Console.WriteLine("максимальное число равно " + max);
}
catch (System.Exception)
{
        Console.WriteLine("Ха-ха-ха");
}
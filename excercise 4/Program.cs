Console.WriteLine("введите число");

try
    {
    double n = Convert.ToDouble(Console.ReadLine());
    }
catch
    {
    Console.WriteLine("ты читать не умеешь? Введи ЧИСЛО");
    }
 int m = Convert.ToInt32(Math.Round(n, 0));
    // int [] arr;
    // arr = new int [(m * 2) + 1];
    // arr[0] = 1;
    // arr[1] = 2;
    // arr[2] = 3;
    Console.WriteLine(m);
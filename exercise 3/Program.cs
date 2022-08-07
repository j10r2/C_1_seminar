string 1 = "Понедельник";
string 2 = "Вторник";
string 3 = "Среда";
string 4 = "Четверг";
string 5 = "Пятница";
string 6 = "Суббота";
string 7 = "Воскресенье";
Console.WriteLine("Введите число от 1 до 7");
string day = Console.ReadLine();
try
{
    Console.WriteLine(day);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ну и чё ты ввёл???");
}
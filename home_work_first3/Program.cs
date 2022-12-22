// Напишите программу, которая на вход принимает число и выдает, является ли число четным или нет
Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}
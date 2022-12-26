// Напишите программу, которая на вход принимает число и выдает, является ли число четным или нет
Console.WriteLine("Введите число:");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 1)
{
    Console.WriteLine("Число " + num1 + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num1 + "является: ЧЁТНЫМ");
}
// See https://aka.ms/new-console-template for more information
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
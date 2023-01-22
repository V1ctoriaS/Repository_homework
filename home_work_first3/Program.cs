// Напишите программу, которая на вход принимает число и выдает, является ли число четным или нет

int num1 = getUserData("Введите число: ");
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

if (num1 % 2 == 1)
{
    Console.WriteLine("Число " + num1 + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num1 + " является: ЧЁТНЫМ");
}
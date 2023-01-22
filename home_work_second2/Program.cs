// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int digitSecond(int number)
{
    int digit2 = number % 100 / 10;
    int result = digit2;
    return result;
}
int randomNumber = GetNumberFromRange(100,999);
int numberSecond = digitSecond(randomNumber);
Console.WriteLine($"Вторая цифра числа {randomNumber} - {numberSecond}");

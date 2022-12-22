// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("max = " + num_A + " " + "min = " + num_B);
}
else
{
    Console.WriteLine("max = " + num_B + " " + "min = " + num_A);
}
            


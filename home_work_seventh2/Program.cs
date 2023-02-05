//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int GetFromUser(string message)  
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] get2DArray(int colLength, int rowLength, int start, int finish) 
{
    int[,] array = new int[colLength, rowLength];   
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1 );
        }
    }
    return array;
} 

void print2DArray(int[,] array)  
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");   
        }
        Console.WriteLine();
    }
}
double FindSum(int[,] array)
{
    double sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + 0.0 + array[i,j];   
        }
        sum = sum / array.GetLength(0);
        Console.Write($"Среднее арифметическое {sum} ");
        Console.WriteLine(" ");
        sum = 0;
    }
    return sum;
} 

int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
Console.WriteLine();
int[,] array = get2DArray(n, m, 0, 100);
print2DArray(array);
double sum = FindSum(array);
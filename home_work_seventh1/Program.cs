// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetFromUser(string message)  
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double[,] get2DDoubleArray(int colLength, int rowLength, int start, int finish) 
{
    double[,] array = new double[colLength, rowLength];   
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(start, finish+1 )) / 10;
        }
    }
    return array;
}

void print2DArray(double[,] array)
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

int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
double[,] array = get2DDoubleArray(n,m,0,100);
print2DArray(array);


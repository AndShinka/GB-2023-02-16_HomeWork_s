// 01_task_HW_2023-02-16
// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();
Console.WriteLine("Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
Console.WriteLine();

void PrintMass1D(double[] massive)
{
    for (int i = 0; i < massive.Length; i++)
        Console.Write($"{massive[i]} \t" !);
    Console.WriteLine();
}

void PrintMass2D(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write($"{massive[i , j]} \t" !);
        Console.WriteLine();
    }
}

int[,] CreateMass(int sizeR, int sizeC)
{   
    int[,] massive = new int[sizeR, sizeC];
    Random rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
        for (int j = 0; j < massive.GetLength(1); j++)
            massive[i , j] = rnd.Next(0 , 11);
    return massive;
}

int ReadNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] AverageColumns(int[,] mass)
{
    double[] AverageColumn = new double[mass.GetLength(1)];
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
            AverageColumn[i] = AverageColumn[i] + mass[j, i];
       AverageColumn[i] = AverageColumn[i] / (mass.GetLength(0));
    }
    return AverageColumn;
}

int numberRows= ReadNum("Enter number of rows:"!);
int numberСolumns= ReadNum("Enter number of columns:"!);
int[,] array = CreateMass(numberRows, numberСolumns);


Console.WriteLine("Задача: Найти среднее арифметическое каждого из столбцов.");
PrintMass2D(array);
Console.WriteLine();
Console.WriteLine($" среднее арифметическое каждого из столбцов равно: ");

PrintMass1D(AverageColumns(array));
Console.WriteLine();
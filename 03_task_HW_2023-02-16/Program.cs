// ##### 03_task_HW_2023-02-16
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("В прямоугольной матрице найти строку с наименьшей суммой элементов.");
Console.WriteLine();

// void PrintMass1D(double[] massive)
// {
//     for (int i = 0; i < massive.Length; i++)
//         Console.Write($"{massive[i]} \t" !);
//     Console.WriteLine();
// }

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

int SearchMinSumRow (int[,] mass)
{
    int  MinSumRow = Int32.MaxValue;
    int  NumMinSumRow = -1;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int  SumRow = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
            SumRow  = SumRow  + mass[i, j];
            
        if (SumRow < MinSumRow) 
            {
                MinSumRow = SumRow;
                NumMinSumRow = i;
            }
    }
    return NumMinSumRow;
}

int numberRows = 0;
int numberСolumns = 0;
while (numberRows == numberСolumns)
{
Console.WriteLine("Задача: В прямоугольной (!) матрице найти строку с наименьшей суммой элементов.");
numberRows= ReadNum("Enter number of rows:"!);
numberСolumns= ReadNum("Enter number of columns:"!);
}
int[,] array = CreateMass(numberRows, numberСolumns);

PrintMass2D(array);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов номер: {SearchMinSumRow(array)} ");

//PrintMass1D(SearchMinSumRow(array));
//Console.WriteLine();

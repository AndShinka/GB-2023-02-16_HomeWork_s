// ##### 02_task_HW_2023-02-16
// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

Console.Clear();
Console.WriteLine("Программа упорядочивания по убыванию элементов каждой строки двумерного массива.");
Console.WriteLine();

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

int[,] MinMaxRow(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int tempMin = 0;
        for (int j = 0; j < mass.GetLength(1) - 1; j++)
        {
            if (mass[i,j] < mass[i,j + 1])
            {
                tempMin = mass[i,j + 1];
                mass[i,j + 1] = mass[i,j];
                mass[i,j] = tempMin;
                j = -1 ;
            }    
        }
    }
    return mass;
}

int numberRows= ReadNum("Enter number of rows:"!);
int numberСolumns= ReadNum("Enter number of columns:"!);
int[,] array = CreateMass(numberRows, numberСolumns);


Console.WriteLine("Задача: упорядочить по убыванию элементы каждой строки следующего двумерного массива:");
PrintMass2D(array);
Console.WriteLine();
Console.WriteLine($" Двумерный массив, элементы каждой строки которого упорядочены по убыванию: ");

PrintMass2D(MinMaxRow(array));
Console.WriteLine();
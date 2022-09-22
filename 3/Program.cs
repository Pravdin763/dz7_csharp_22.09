// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите колличество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(20);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}


void Average(int[,] matr)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count += array[i, j];
        }
        double total = (double)count / (double)m;
        Console.WriteLine($"Среднее арифметическое стобла {j + 1} = {Math.Round(total, 2)}");
    }
}


FillArray(array);
PrintArray(array);
Average(array);
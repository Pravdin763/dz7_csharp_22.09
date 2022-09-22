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

FillArray(array);
PrintArray(array);


for (int i = 0; i < array.GetLength(0); i++)
{
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count += array[j, i];
    }
    double total = count / (double)n;
    Console.WriteLine($"Среднее арифметическое стобла {i + 1} = {Math.Round(total, 2)}");
}



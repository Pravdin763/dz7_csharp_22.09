// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            matr[i, j] = new Random().Next(-10, 11);
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


void PrintElement(int[,] matr)
{
    Console.WriteLine("Введите индексы матрицы: ");
    Console.WriteLine("Введите индекс строки ");
    int row = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите индекс столбца ");
    int col = int.Parse(Console.ReadLine()!);

    if (row > m - 1 || row < 0 || col > n - 1 || col < 0)
    {
        Console.WriteLine("Такого элемента нет, вы ввели индексы вне массива");
    }
    else
    {
        Console.WriteLine($"Значение массива по индексам {row} и {col}  = {matr[row, col]}");
    }
}

FillArray(array);
PrintArray(array);
PrintElement(array);
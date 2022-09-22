using System;
using System.Linq;
using System.Text;


// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите колличество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];

Random rnd = new Random();


void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
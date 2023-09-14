// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
﻿void FillRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}
Console.Write("Введите количество строк 1 массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Матрицы не перемножаются (матрицы доложны быть: Пример 2 х 2)!");
    return;
}
int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
FillRandomArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];
FillRandomArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);
using System;
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double Random () 
{
    Random rand = new Random();
    double randomNumberForArray = rand.Next(-10, 10) + rand.NextDouble();
    return randomNumberForArray;
}

double[,] GreatArray(int m, int n) 
{   
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(Random (),1);  
        }
    }
    return array;
} 

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
    } 
} 

double[,] arrayNew = GreatArray(3, 4); 
PrintArray(arrayNew);
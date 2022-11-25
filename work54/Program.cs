// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Random () 
{
    Random rand = new Random();
    int randomNumberForArray = rand.Next(1, 10);
    return randomNumberForArray;
}

int[,] GreatArray(int m, int n) 
{   
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Random ();  
        }
    }
    return array;
} 

void ReversMassiv(int[,] array)
{   
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); ++i)
    { 
        for (int j = 0; j < array.GetLength(1); ++j)
        {    
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }         
        }
    }   
}


void PrintArray (int[,] array)
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

int[,] arrayNew = GreatArray(3,4); 
PrintArray(arrayNew);
Console.WriteLine();
ReversMassiv(arrayNew);
PrintArray (arrayNew);
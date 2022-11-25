// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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


void ProizvedeniaVoidMassiv(int[,] arrayOne, int[,] arrayTwo)
{   
    
   int [,] result = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); ++i)
    {  
        for (int j = 0; j < arrayTwo.GetLength(1); ++j)
        {    
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                result[i,j] += arrayOne[i,k] * arrayTwo[k,j];
            }
        }   
    }    
PrintArray(result);
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

int[,] arrayNewOne = GreatArray(2,2); 
int[,] arrayNewTwo = GreatArray(2,2);


PrintArray(arrayNewOne);
Console.WriteLine();

PrintArray(arrayNewTwo);
Console.WriteLine();

ProizvedeniaVoidMassiv(arrayNewOne,arrayNewTwo);

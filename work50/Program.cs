using System;
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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


int EnterNumberForCheckout() 
{
    Console.WriteLine("Введите координат");
    string enterStrDataUsers = Console.ReadLine();
    int.TryParse(enterStrDataUsers, out int numberDataUsers);
    return numberDataUsers;
}



void CheckMassivOnNumberIndex(int[,] array)
{   
    int m = EnterNumberForCheckout();
    int n = EnterNumberForCheckout();
    int flag = 0;
    int[] pos = new int[2] { m, n};   
    for (int i = 0; i < array.GetLength(0); i++)
        {
    for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i == pos[0] && j == pos[1] )
                {   
                    Console.WriteLine();
                    Console.Write($"значение этого элемента равно: => {array[i,j]} "); 
                    flag = 1;
                }  
                
                
            }
        }
    if(flag == 0) Console.Write($"таких кордиант в массиве нет");
    // return pos;
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

int[,] arrayNew = GreatArray(3, 4); 
PrintArray(arrayNew);
CheckMassivOnNumberIndex(arrayNew); 
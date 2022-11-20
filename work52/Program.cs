// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void CheckMassivOnNumberIndex(int[,] array)
{   
    int k = 0;
    int[] acumVoid = new int[4];
    for (int i = 0; i < array.GetLength(0)+1; i++)
        { 
    for (int j = 0; j < array.GetLength(1)-1; j++)
            {    
               acumVoid[i] += array[j, i];    
            }
        } 
    foreach (double elem in acumVoid)
            {
                Console.Write($"Среднее арифметическое для столбца {++k} - {Math.Round(elem/3,1)}: "); //вывод среднего для колонки
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
CheckMassivOnNumberIndex(arrayNew);

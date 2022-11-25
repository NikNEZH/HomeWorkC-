// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
    
    int sumLine = array[0,0] + array[0,1] + array[0,2] + array[0,3]; // можно было бы вывести функцией, это подсчет суммы значений первой строки
    Console.WriteLine($"{sumLine}  ");
    int flag = 0;
    int tempLine = 0;
    for (int i = 1; i < array.GetLength(0); ++i)
    {  
        for (int j = 0; j < array.GetLength(1); ++j)
        {    
            tempLine += array[i, j];
        } if ( tempLine < sumLine )
            {
                sumLine = tempLine;
                flag = i;
            }     
        Console.WriteLine($"{tempLine}  ");
    }    
Console.WriteLine($"{flag+1} - строкa с наименьшей суммой ({sumLine}) элементов ");   
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

int[,] arrayNew = GreatArray(4,4); 
PrintArray(arrayNew);
Console.WriteLine();
ReversMassiv(arrayNew);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int Random () 
{
    Random rand = new Random();
    int randomNumberForArray = rand.Next(10, 99);
    return randomNumberForArray;
}

int[,,] GreatArray(int m, int n, int l) 
{   
    int[,,] array = new int[m,n,l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            for (int k = 0; k < l; k++)
            {
                array[i,j,k] = Random ();
            }
        }
    }
    return array;
} 


// void ProizvedeniaVoidMassiv(int[,] arrayOne)
// {   
    
//    int [,] result = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];
//     for (int i = 0; i < arrayOne.GetLength(0); ++i)
//     {  
//         for (int j = 0; j < arrayTwo.GetLength(1); ++j)
//         {    
//             for (int k = 0; k < arrayOne.GetLength(1); k++)
//             {
//                 result[i,j] += arrayOne[i,k] * arrayTwo[k,j];
//             }
//         }   
//     }    
// PrintArray(result);
// }

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"({i},{j},{k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
} 

int[,,] arrayNewOne = GreatArray(2,2,2); 


PrintArray(arrayNewOne);
Console.WriteLine();
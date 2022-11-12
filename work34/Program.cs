// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray()
{
    Random rnd = new Random();
    int k = rnd.Next(5,10);
    int[] result = new int[k];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100,999);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CheckingAnArrayForParity(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {        
        if(array[i] % 2 == 0) Console.Write($"{array[i]} ");

    }
    
}

int[] a = InitArray();
PrintArray(a);
CheckingAnArrayForParity(a);
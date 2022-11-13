// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] InitArray()
{
    Random rnd = new Random();
    int k = rnd.Next(3,7);
    int[] result = new int[k];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1,100);
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

int acum = 0;
void CheckingAnArrayForParity(int[] array)
{
    
    for (int i = 1; i < array.Length; i = i+2)
    {        
        acum =  acum +array[i];
    }
    Console.Write($"{acum} ");
}

int[] a = InitArray();
// int[] b = {3, 7, 23, 12};
PrintArray(a);
CheckingAnArrayForParity(a);
// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] InitArray(int n) 
{
    double[] array = new double[n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) 
    {
    array[i] = rand.Next(1, 100) + rand.NextDouble();
    array[i] = Math.Round(array[i], 2);
    Console.Write($"{array[i]} ");
    } 

    return array;
}

(double,double) GetMaxAndMinSumm(double[] array)
{
    double max = 0; 
    double min = 100;
    for (int i = 0; i < array.Length -1; i++)
    {   
        if(array[i]>max) max = array[i];
        else if (array[i]<min) min = array[i];
    }
    return (max, min);
}

double[] a = InitArray(5);
(double max, double min) = GetMaxAndMinSumm(a);
Console.WriteLine();
Console.WriteLine($"Разницу между максимальным и минимальным : {Math.Round(max - min, 2)} ");
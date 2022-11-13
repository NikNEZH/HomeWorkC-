// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}


double[] Get (string message) 
{
    
    int k1 = GetNumber("Координаты для k1");
    int b1 = GetNumber("Координаты для b1");

    int k2 = GetNumber("Координаты для k2");
    int b2 = GetNumber("Координаты для b2");

    double[] result = {k1, b1, k2, b2};
    return result;

} 

(double,double) GetMaxAndMinSumm(double[] array)
{
    double y0 = (array[3] - array[1]) / (array[0] - array[2]); 
    double y1 = array[2] * y0 + array[3];

    return (y0, y1);
}

var a = Get ("Введите данные");
(double y0, double y1) = GetMaxAndMinSumm(a);
Console.WriteLine();
Console.WriteLine($"Разницу между максимальным и минимальным : {(y0)};{(y1)} ");

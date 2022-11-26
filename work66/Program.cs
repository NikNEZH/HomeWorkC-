// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int PrintNimbers(int numberM, int numberN)
{   
    
    if (numberN == numberM)
       return numberM;
    else
    {   
        Console.Write($"{numberN} ");
        return numberN + PrintNimbers(numberM, numberN - 1);
        
    }
}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");;
Console.WriteLine();
int results = PrintNimbers(numberM,numberN);
Console.WriteLine();
Console.WriteLine();
Console.Write(results);
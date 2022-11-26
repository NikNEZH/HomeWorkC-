/*Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. 
 Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void PrintNimbers(int number, int count)
{
    if(count <= number && number !=0 )
    {
    Console.Write($"{number--} ");
    PrintNimbers(number--, count++);
    } else if (number == 0)
    {
        Console.Write("");
    }
}

int number = GetNumber("Введите число M:");
int count = 0;
PrintNimbers(number,count);

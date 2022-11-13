// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Сколько чисел вы хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write("Enter number ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0) count ++;
}
Console.Write(count);
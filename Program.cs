// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

/* 
int CountNumber (int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write ($"Input number ({number-i} attempts left): ");
        int num = Convert.ToInt32 (Console.ReadLine());
        
        if (num > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Write ("Нow many numbers you enter (you do not need much, you will get tired): ");
int m = Convert.ToInt32 (Console.ReadLine());

int res = CountNumber (m);

Console.Write ($"You entered {res} numbers greater than 0 out of {m} numbers.");
 */

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
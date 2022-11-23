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
/* 
void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.Write ("Straight lines match. No intersection point.");
    }
    else if (k1 == k2)
    {
        Console.Write ("Straight lines are parallel. No intersection point.");
    }
    else
    {
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
    double y = Math.Round((k1 * x + b1), 1);
    // double y2 = Math.Round((k2 * x + b2), 1);
    Console.Write ($"Straight lines intersect. Intersection point (x; y): ({x}; {y}).");
    }
}

Console.Write ("Input b1 in the equation y = k1 * x + b1: ");
double b1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input k1 in the equation y = k1 * x + b1: ");
double k1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input b2 in the equation y = k2 * x + b2: ");
double b2 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input k2 in the equation y = k2 * x + b2: ");
double k2 = Convert.ToInt32 (Console.ReadLine());

IntersectionPoint (b1, k1, b2, k2);
 */

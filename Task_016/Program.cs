// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.Write("Введите первое число: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

System.Console.Write("Введите второе число: ");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (a == b*b || b == a*a)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
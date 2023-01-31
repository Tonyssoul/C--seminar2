// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
System.Console.WriteLine($"Случайно число: {number}");

// int leftnumber = number / 10;
// int rightnumber = number % 10;

// System.Console.WriteLine($"{leftnumber} {rightnumber}");

if (number / 10 > number % 10)
{
    System.Console.WriteLine($"Левое число больше и равно: {number / 10}");
}
else if (number / 10 < number % 10)
{
    System.Console.WriteLine($"Правое число больше и равно: {number % 10}");
}
else
{
    System.Console.WriteLine("числа равны");
}
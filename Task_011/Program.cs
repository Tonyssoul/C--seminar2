// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
System.Console.WriteLine($"Случайно число: {number}");

// int leftnumber = number / 100;
// int rightnumber = number % 10;

// System.Console.WriteLine($"{leftnumber}{rightnumber}");

number = ((number/100)*10) + (number%10);

System.Console.WriteLine(number);
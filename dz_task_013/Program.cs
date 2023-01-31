// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99)
{
    while (a > 999)
    {
        a = a / 10;
    }
    System.Console.WriteLine(a % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры в данном числе нет");
}
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите цифру дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>0 && a<8)
{
    if(a == 6 || a==7)
    {
        System.Console.WriteLine("ДА");
    }
    else
    {
        System.Console.WriteLine("НЕТ");
    }
}
else
{
    System.Console.WriteLine("Такого дня недели нет");
}
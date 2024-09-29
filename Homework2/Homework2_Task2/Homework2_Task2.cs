/*
Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

using System;

while (true)
{
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out int num))
    {
        if (num < 100 && num > -100)
        {
            Console.WriteLine("третьей цифры нет");
            break;
        }
        else
        {
            Console.WriteLine($"3-я цифра числа - {num.ToString()[2]}");
            break;
        }
    }
    Console.WriteLine("Ошибка ввода! Введите целое число!");
}

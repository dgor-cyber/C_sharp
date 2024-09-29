/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

using System;

while (true)
{
    Console.Write("Введите целое трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out int num) && num < 1000 && num > 99)
    {
        int secondDigit = num / 10 % 10;
        Console.WriteLine($"2-я цифра числа - {secondDigit}");
        break;
    }
    Console.WriteLine("Ошибка ввода! Введите целое трехзначное число!");
}

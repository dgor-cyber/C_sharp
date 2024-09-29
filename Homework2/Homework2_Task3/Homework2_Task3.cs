/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

using System;

while (true)
{
    Console.Write("Введите номер дня недели от 1 до 7: ");
    if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 7)
    {
        if (num < 6)
        {
            Console.WriteLine("Будний день.");
            break;
        }
        else
        {
            Console.WriteLine("Выходной день. Ура!");
            break;
        }
    }
    Console.WriteLine("Такого дня недели нет! Введите корректный день недели.");
}

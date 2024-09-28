using System;
using System.Collections.Generic;

Console.Clear();

var weekDays = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"},
};

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());

if ((num >= 1) & (num <= 7))
{
    Console.WriteLine($"Номер дня: {num}.  Название: {weekDays[num]}");
}
else
{
    Console.WriteLine("Вы ввели некорректный номер дня недели.");
}

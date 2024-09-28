using System;

Console.Clear();

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int rest = num % 10;

Console.WriteLine($"Последняя цифра введенного числа: {rest}");

using System;

Console.Clear();

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

for (int i = -num; i <= num; i++)
{
    Console.Write(i + " ");
}

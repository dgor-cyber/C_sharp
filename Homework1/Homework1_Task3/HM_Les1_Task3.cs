/*
Задание 3
Определение, является ли число положительным
Описание: Напишите метод, который на вход принимает число и выводит, является ли
оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.
Пример использования: На входе:
● number: 7
На выходе:
● положительное
На входе:
● number: -3
На выходе:
● отрицательное
На входе:
● number: 0
На выходе:
● ноль
*/


using System;
class Answer
{
    static void CheckNumber(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("положительное");
        }
        else if (number < 0)
        {
            Console.WriteLine("отрицательное");
        }
        else
        {
            Console.WriteLine("ноль");
        }
    }
    static public void Main(string[] args)
    {
        int number;
        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 7;
        }
        CheckNumber(number);
    }
}

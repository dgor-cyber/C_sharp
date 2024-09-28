/*
Задание 1
Определите, делится ли число на другое
Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
делится ли первое число на второе. Если делится, выводите "делится", иначе
выводите "не делится".
Пример использования: На входе:
● firstNumber: 10
● secondNumber: 2
На выходе:
● делится
На входе:
● firstNumber: 10
● secondNumber: 3
На выходе:
● не делится
*/

using System;
public class Answer
{
    static void CheckDivisibility(int firstNumber, int secondNumber)
    {
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine("делится");
            }
            else
            {
                Console.WriteLine("не делится");
            }
        }

    }
    static public void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Введите 1е целое число");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число");
        }

        Console.WriteLine("Введите 2е целое число");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число");
        }

        CheckDivisibility(a, b);
    }
}

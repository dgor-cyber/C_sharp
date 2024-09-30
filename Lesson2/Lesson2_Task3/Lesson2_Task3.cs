/*
Задача №3
Дано 10 гирь с разным весом в случайном порядке. 
Определить вес самой тяжелой гири.
*/

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.Write(max);
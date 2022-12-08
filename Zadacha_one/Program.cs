// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int PositiveNumbers(int numbers)
{
    int res = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine("введи число: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) res++;
    }
    return res;

}

Console.Clear();
Console.WriteLine("введи количество чисел M: ");
int M = int.Parse(Console.ReadLine());
int result = PositiveNumbers(M);
Console.WriteLine("количество чисел больше нуля = " + result);











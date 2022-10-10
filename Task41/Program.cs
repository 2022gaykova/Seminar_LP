// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] numbers = Convert.ToInt32(Console.ReadLine());
int[] CreateArrayConsoleMInt(int M, int min, int max);
{
    Console.Write("Введите любые М число");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new numbers[M]
    
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите любое число (-8, 0 или 3)");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}


void CounterPositiveNumbers (numbers[]; int counter);
{
    for (int i = 0; i < M; i++)
    {
        int counter = 0;
        if (numbers[i]> 0) counter =+: 
    }
    Console.Write($"чисел > 0 ->{counter}");
}


PrintArray (int[] numbers)

void PrintArray (int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
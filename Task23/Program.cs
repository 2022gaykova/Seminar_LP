// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт
//  таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// int InputNumber( char "Введите число: ");
// {
    // Console.WriteLine("Введите число: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // return number;


int NumberToCubes(int number)
{
    Console.WriteLine($"{number} ->");
    int cube = default;
    for (int k = 1; k <= number; k++)
       {
            cube = k * k * k;
            Console.Write($"{cube} "); 
        }
        return cube;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
NumberToCubes(num);

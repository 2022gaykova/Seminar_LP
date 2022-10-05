// Задача 6. Напишите программу, которая на входе принимает число
// и выдает, является ли число четным
// 4 -> да
// 5 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.Write($"{number}-> да"); 
else Console.Write($"{number}-> нет"); 

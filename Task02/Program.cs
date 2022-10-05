// Задача2. Напишите программу, которая на вход принимает
// 2 числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 5; b = 7 -> max = 7
// a = 5; b = 7 -> max = 7

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) Console.Write($"max = {num1}");
else Console.Write($"max = {num2}");

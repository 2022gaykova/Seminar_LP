// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 9int


int PrintSecondNumber(int number)
{
   int result = number % 100 / 10;
   Console.WriteLine($"{number} => {result}");
   return result;
}
int number = new Random().Next(100, 1000);
PrintSecondNumber(number);

// int num = PrintSecondNumber(number); 
// Console.WriteLine($"{number} => {result}");
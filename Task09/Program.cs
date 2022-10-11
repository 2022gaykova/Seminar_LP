// 9. Напишите программу, которая выводит случайное
// 

// 78 -> 8
// 85 -> 8
// 88 -> 

int number = 99; // new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit == secondDigit) System.Console.WriteLine("Цифры равны");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");


int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // бинарный  оперант
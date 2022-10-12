// // Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// int number1 = InputIntData("Введите 1 число");
// int number2 = InputIntData("Введите 2 число");
// if (number1 < number2)
// {
//     NaturalNumInRange(number1, number2);
// }
// else
// {
//     NaturalNumInRange(number2, number1);
// }


// void NaturalNumInRange(int num1, int num2)
// {
//     if (num1 > num2) return;
//     NaturalNumInRange(num1, num2 - 1);
//     Console.Write($"{num2} ");
// }

int InputIntData(string "Введите число: ")
{
    txt = Console.WriteLine("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}
num = InputIntData(txt);
Console.WriteLine(num);

//Задача 40: Напишите программу, которая принимает на вход три
//чсла и проверяет, может ли существовать треугольник с сторонами
//такой длины.

System.Console.WriteLine("Число1");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число2");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число3");
int num3 = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2);
    
}

if(CheckTriangle (num1, num2, num3)) System.Console.WriteLine("Cуществует");
else System.Console.WriteLine("Не Cуществует");
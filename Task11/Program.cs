// 11.Напишите программу, которая выводит случайное 3хзначное
//  число и удаляет 2ю цифру этого
// 456 => 46

int number = new Random().Next(100,1000);
int RemoveSecondDigit( int num)
{
    int thirdDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + thirdDigit;
}

int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");
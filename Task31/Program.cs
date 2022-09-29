// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{

}

int [] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;
    for (int i = 0, i < array.Length, i++)
    {
        if (array[i] < 0) sumNegative += array[i]; //sumNegative =sumNegative =+ array[i]    }
        else sumPositive += array[i];// sumPositive = sumPositive + array[i]


}
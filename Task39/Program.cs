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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ReverseArray (int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
      int obj = array[index1];
      array[index1] = array[index2];
      array[index2] =  obj;

      index1++;
      index2--; 
    }
}

int[] arr = CreateArrayRndInt(8, -9, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
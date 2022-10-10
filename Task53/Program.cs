// // Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
    { 
       for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
        matrix[i, j] = rnd.Next(min, max + 1);    
        }
    }
    return matrix;
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
                    else Console.Write($"{matrix[i, j], 4}");
                }
                Console.WriteLine("|");
        }
} 

// void ReplaceOneAndLastRowsMatrix(int[,] matrix)
// {
//     for (int j = 0; j < Matrix.Get.length(0); j++)
//      {
//         fixed obj[0, j] == matrix[0, j];
//         matrix[0,j] = matrix[matrix.GetLength(0), j];
//         matrix[matrix.GetLength(0), j] = obj [0, j];
//     }
// }

int [,] matr = CreateMatrixRndInt(3, 4, -5, 10);
PrintMatrix(matr);
Console.WriteLine();
// ReplaceOneAndLastRowsMatrix(matr);
PrintMatrix(matr);

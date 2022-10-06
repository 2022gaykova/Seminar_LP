// Задача 48.

int[,] CreateMatrixSumIndex(int rows,int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++) //rows (0)
    { 
       for (int j = 0; j < columns; j++) //columns (1)
        {
        matrix[i, j] = i + j;    
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

int [,] array2D = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2D);

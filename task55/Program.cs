// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.
int[,] FillMatrix(int leftRange = 1, int rightRange = 9)
{
    int[,] matrix = new int[3, 3];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//Console.Write("Введите m и n через Enter "); 

//int m = Convert.ToInt32(Console.ReadLine());//число строк
//int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix();
PrintMatrix(matrix);
int[,] matrix2 = new int[3, 3];
 void RollMatrix(int[,] matrix)
 {
//int[,] matrix2 = new int[3, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix2[i, j] = matrix[j, i];
    }
}
//return matrix2;
}

Console.WriteLine("-------------");
RollMatrix(matrix);
PrintMatrix(matrix2);

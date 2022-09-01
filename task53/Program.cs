// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] FillMatrix(int leftRange = 1, int rightRange = 9)
{
    int[,] matrix = new int[5, 5];

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



        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[0, j];
            matrix[0,j] = matrix[matrix.GetLength(1) - 1,  j];
            matrix[matrix.GetLength(1) - 1, j] = temp;
        }
    



Console.WriteLine("-------------");
PrintMatrix(matrix);

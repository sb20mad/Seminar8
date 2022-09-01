// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] FillMatrix(int leftRange = 1, int rightRange = 9)
{
    int[,] matrix = new int[2, 2];

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

int[,] matrix = FillMatrix(); //создал массив
int[,] matrix2 = FillMatrix(); //создал массив2
int[,] summatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; //Подготовим упорядоченый массив

PrintMatrix(matrix); //начепятал массив 
Console.WriteLine("_______________");
PrintMatrix(matrix2); //начепятал массив 2
//заполним суммовой массив
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summatrix[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
Console.WriteLine("_______________");
PrintMatrix(summatrix);
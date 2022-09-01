// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите m и n через Enter "); 

int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] FillMatrix(int leftRange = 1, int rightRange = 9)
{
    int[,] matrix = new int[n, m];

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

int[,] matrix = FillMatrix();
PrintMatrix(matrix);
//int[,] orderMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; //Подготовим упорядоченый массив
void order(int[,] matrix) //Сортируем массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int n = 0; n < matrix.GetLength(1) - 1; n++)
      {
        if (matrix[i, n] < matrix[i, n + 1])
        {
          int temp = matrix[i, n + 1];
          matrix[i, n + 1] = matrix[i, n];
          matrix[i, n] = temp;
        }
      }
    }
  }
}
order(matrix);
Console.WriteLine();
PrintMatrix(matrix);

//Задача 61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника
// int[,] FillMatrix(int leftRange = 1, int rightRange = 9)
// {
//     int[,] matrix = new int[5, 5];

//     Random rand = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// //Console.Write("Введите m и n через Enter "); 

// //int m = Convert.ToInt32(Console.ReadLine());//число строк
// //int n = Convert.ToInt32(Console.ReadLine());//число столбцов
// int[,] matrix = FillMatrix();
// PrintMatrix(matrix);
// Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] pascal = new double[n, 2 * n + 1];

void Fillpascal(double[,] pascal)
{
  for (int k = 0; k < pascal.GetLength(0); k++)
  {
    pascal[k, 0] = 1;
  }
  for (int i = 1; i < pascal.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
    }
  }
}
Fillpascal(pascal);

void PrintMatrix(double[,] pascal)
{
    for (int i = 0; i < pascal.GetLength(0); i++)
    {
        for (int j = 0; j < pascal.GetLength(1); j++)
        {
            Console.Write(pascal[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(pascal);

Console.WriteLine();

void Trans(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

Trans(pascal);
PrintMatrix(pascal);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Console.Write("Введите m и n через Enter "); 
// int m = Convert.ToInt32(Console.ReadLine());//число строк
// int n = Convert.ToInt32(Console.ReadLine());//число столбцов

int[,] matrix = FillMatrix(7, 3);
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 10)//заполнить массив
{
    int[,] matrix = new int[rowsCount, columnsCount];

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
void PrintMatrix(int[,] matrix)//вывести массив в консоль
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
int LineSum(int[,] matrix, int i) //сумма строк
{
  int sum = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sum = sum + matrix[i,j];
  }
  Console.WriteLine($"Сумма строки {i+1} = {sum}");
  return sum;
  
}

PrintMatrix(matrix);

int minSumLine = 0; //номер строки с минимальной суммой 
int sumLine = LineSum(matrix, 0);//сумма строки

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = LineSum(matrix, i);//временная переменная которая хранит минимальную сумму строки
  if (sumLine > temp)
  {
    sumLine = temp;
    minSumLine = i;
  }
}
Console.WriteLine($"строкa {minSumLine+1} - строкa с наименьшей суммой ({sumLine})");
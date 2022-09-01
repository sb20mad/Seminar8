// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
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

int[,] matrix = FillMatrix(); //создал массив
PrintMatrix(matrix); //начепятал массив
int[,] matrixDelLines = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]; //Создал массив на 1 строку и столбец меньше пригодится
int[,] pos = new int[1, 2]; //массив для позиции самого маленького числа

pos = FindSmall(matrix, pos);
int[,] FindSmall(int[,] matrix, int[,] pos)//ищем самое малое число и передаем его в его массив
{
    int temp = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < temp) ///первый попавшийся
           // if (matrix[i, j] == temp)  // последний попавшийся
            {          
                pos[0, 0] = i;
                pos[0, 1] = j;
                temp = matrix[i, j];               
            }
        }
    }
    Console.WriteLine($"Самое малое число: {temp}");
    return pos;
}
           
void Delete(int[,] matrix, int[,] pos, int[,] matrixDelLines)//заполняем подготовленый массив отсекая строку и столбец с самым малым числом
{
  int k = 0, l = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (pos[0,0] != i && pos[0, 1] != j)
      {
        matrixDelLines[k, l] = matrix[i, j];
        l++;
      }
    }
    l = 0;
    if (pos[0, 0] != i)
    {
      k++;
    }
  }
}


Delete(matrix, pos, matrixDelLines);
Console.WriteLine($"Получившийся массив:");
PrintMatrix(matrixDelLines);
//WriteArray(matrixDelLines);

// int temp=1000000000;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (temp > matrix[i,j])
//         temp = matrix[i,j];
//     }
//     }




//     int[,] matrix2 = FillMatrix();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i,j]==temp)
//         temp = matrix[i,j];
// }

// }

//PrintMatrix(matrix);
//FindSmallElement(matrix);
//Console.WriteLine(temp);




//Console.Write("Введите m и n через Enter "); 

//int m = Convert.ToInt32(Console.ReadLine());//число строк
//int n = Convert.ToInt32(Console.ReadLine());//число столбцов






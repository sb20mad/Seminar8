// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.Write("Введите количество строк и столбцов ");
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matr = new int[n, n];

int row = 0;//строки
int col = 0;//колонки
int x = 1;
int y = 0;
int Changes = 0;
int count = n;

for (int i = 0; i < matr.Length; i++)
{
    matr[row, col] = i + 1;
    if (--count == 0)
    {
        count = n * (Changes % 2) + n * ((Changes + 1) % 2) - (Changes / 2 - 1) - 2;
        int temp = x;
        x = -y;
        y = temp;
        Changes++;
    }

    col = col+x;
    row = row+y;

}


PrintMatrix(matr);


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" "+matrix[i, j] );
        }
        Console.WriteLine();
    }
}








// for (j = 0, i = 0; j < n; j++)
//     matr[i, j] = x++;
// for (i = 0, j = n - 1; i < n; i++)
//     matr[i, j] = x++;
// for (j = n - 2, i = n - 1; j >= 0; j--)
//     matr[i, j] = x++;
//    for (i = n-1, j = 0; i < n-3; i--)
//     matr[i, j] = x++; 


// //PrintMatrix(matr);


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
























// int i, j;
// for (j = 0, i = 0; j < n; j++)
//     matr[i, j] = 1;
// for (i = 0, j = n - 1; i < n; i++)
//     matr[i, j] = 1;
// for (j = n - 1, i = n - 1; j >= 0; j--)
//     matr[i, j] = 1;
// int count = 3;
// int c = 0;
// i = n - 1;
// j = 0;
// for (int x = n - 3; x > 0; x -= 2)
// {
//     if (n % 2 == 0 & x == 1)
//         c = 1;
//     else
//         c = 0;
//     while (c < 2)
//     {
//         switch (count)
//         {
//             case 1: //вниз
//                 for (int t = 0; t < x; t++)
//                 {
//                     i++;
//                     matr[i, j] = 1;
//                 }
//                 count++;
//                 break;
//             case 2: //лево
//                 for (int t = 0; t < x; t++)
//                 {
//                     j--;
//                     matr[i, j] = 1;
//                 }
//                 count++;
//                 break;
//             case 3: //вверх
//                 for (int t = 0; t < x; t++)
//                 {
//                     i--;
//                     matr[i, j] = 1;
//                 }
//                 count++;
//                 break;
//             case 4: //право
//                 for (int t = 0; t < x; t++)
//                 {
//                     j++;
//                     matr[i, j] = 1;
//                 }
//                 count = 1;
//                 break;
//         }
//         c++;
//     }
// }
// for (int ii = 0; ii < n; ii++)
// {
//     for (int jj = 0; jj < n; jj++)
//         Console.Write(matr[ii, jj]);
//     Console.WriteLine();
// }


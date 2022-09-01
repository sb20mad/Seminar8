// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
int[,] matr = new int[4, 4];
Console.WriteLine();
int i, j;
for (j = 0, i = 0; j < n; j++)
    matr[i, j] = 1;
for (i = 0, j = n - 1; i < n; i++)
    matr[i, j] = 1;
for (j = n - 1, i = n - 1; j >= 0; j--)
    matr[i, j] = 1;
int count = 3;
int c = 0;
i = n - 1;
j = 0;
for (int x = n - 3; x > 0; x -= 2)
{
    if (n % 2 == 0 & x == 1)
        c = 1;
    else
        c = 0;
    while (c < 2)
    {
        switch (count)
        {
            case 1: //вниз
                for (int t = 0; t < x; t++)
                {
                    i++;
                    matr[i, j] = 1;
                }
                count++;
                break;
            case 2: //лево
                for (int t = 0; t < x; t++)
                {
                    j--;
                    matr[i, j] = 1;
                }
                count++;
                break;
            case 3: //вверх
                for (int t = 0; t < x; t++)
                {
                    i--;
                    matr[i, j] = 1;
                }
                count++;
                break;
            case 4: //право
                for (int t = 0; t < x; t++)
                {
                    j++;
                    matr[i, j] = 1;
                }
                count = 1;
                break;
        }
        c++;
    }
}
for (int ii = 0; ii < n; ii++)
{
    for (int jj = 0; jj < n; jj++)
        Console.Write(matr[ii, jj]);
    Console.WriteLine();
}
Console.ReadLine();

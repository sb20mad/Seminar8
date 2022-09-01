// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = 2;
// int y = 2;
// int z = 2;
int[] array = new int[8];
Random rand = new Random();
{
for (int i = 0; i < array.Length; i++) 
{
    bool Uniq;
    do
    {
        array[i] = rand.Next(10, 20);
        Uniq = true;
        for (int j = 0; j < i; ++j)
            if (array[i] == array[j])
            {
                Uniq = false;
                break;
            }

    } while (!Uniq);
}
}
Console.WriteLine(string.Join("*", array));

Console.WriteLine();


int  x;
int[,,] arr3d = new int[2, 2, 2];
x = 0;
for (int i= 0; i < arr3d.GetLength(0); i++)
    for (int j = 0; j < arr3d.GetLength(1); j++)
        for (int k = 0; k < arr3d.GetLength(2); k++)
            arr3d[i, j, k] = array[x++];

 


PrintMatrix(arr3d);

void PrintMatrix(int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"{arr3d[i, j, k]}--({i},{j},{k})");

                // Console.Write( $"{arr3d[i,j,k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}












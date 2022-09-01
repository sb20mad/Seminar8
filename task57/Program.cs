// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9
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
int[] arr = new int[10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arr[matrix[i, j]] = arr[matrix[i, j]] + 1;
    }
}
// Console.WriteLine("-------------");
//Console.WriteLine(string.Join(", ", matrix));
for (int i = 0; i < arr.Length; i++)
    Console.WriteLine($"Число {i} встречается - {arr[i]} раз");
// Console.WriteLine("-------------");
//PrintMatrix(matrix);
// int temp = 0;
// if (temp = matrix.GetLength(1))
// {
// matrix[i,j] == matrix[j+1, i+1];        
//     temp++;
// }

//matrix[i, j] = matrix[j, i];


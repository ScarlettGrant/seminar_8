// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(15);
        }
    }
}

void PrintArray1(int[,] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
       System.Console.WriteLine();      
    }
    System.Console.WriteLine();
}

int[,] ProductOfMatrixes(int[,] matr1, int[,] matr2)
{
    int[,] resultMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
        for (int j = 0; j < matr2.GetLength(1); j++)
            for (int k = 0; k < matr1.GetLength(1); k++)
                resultMatrix[i, j] += matr1[i, k] * matr2[k,j];
    return resultMatrix;
}

System.Console.Write("Введите количество строк для матрицы A: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк для матрицы B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows2, columns2];

if (columns != rows2) 
Console.WriteLine($"Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
else
{
    FillArray(matrix1);
    FillArray(matrix2);
    System.Console.WriteLine($"matrix A");
    PrintArray1(matrix1);
    System.Console.WriteLine($"matrix B");
    PrintArray1(matrix2);
    PrintArray1(ProductOfMatrixes(matrix1, matrix2));
}



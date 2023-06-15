// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
       System.Console.WriteLine();      
    }
}

int[] SumInRow(int[,] arr)
{
    int[] array = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        array[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            array[i] += arr[i, j];
    }
    return array;
}

string FindMin(int[] col)
{
    int minimal_sum = col[0];
    int row = 0;
    for (int i = 1; i < col.Length; i++)
    {
        if (minimal_sum > col[i]) 
        {
            minimal_sum = col[i];
            row = i + 1;
        }
    }
    return $"наименьшая сумма равна {minimal_sum} в строке {row}";
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int[] answer = SumInRow(array);

System.Console.WriteLine(FindMin(answer));

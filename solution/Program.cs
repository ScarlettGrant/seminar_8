//Напишите программу, которая заполнит спирально массив N на N.
//N вводит с клавиатуры пользователь.


void CreateSpiral(int[,] array)
{
    int x = 1;

    for (int shift = 0; shift <= array.GetLength(0) - 2; shift++)
    {
        for (int i = 0 + shift; i < array.GetLength(0) - shift; i++)
        {
            array[0 + shift, i] = x;
            x++;
        }
        x--;       
        for (int i = 0 + shift; i < array.GetLength(0) - shift; i++)
        {
            array[i, array.GetLength(0) - 1 - shift] = x;
            x++; 
        }  
        x--;
        for (int i = array.GetLength(0) - 1 - shift; i >= 0 + shift; i--)
        {
            array[array.GetLength(0) - 1 - shift, i] = x;
            x++;
        }
        x--;
        for (int i = array.GetLength(0) - 1 - shift; i > 0 + shift; i--)
        {
            array[i, 0 + shift] = x;
            x++;
        }      
    }
}

void PrintSpiral(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(0); columns++)
        {
            System.Console.Write($"{array[rows, columns],3} ");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите сторону квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

CreateSpiral(matrix);
PrintSpiral(matrix);
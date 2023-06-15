// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int randNumber = new Random().Next(10, 100);

                while(MatrixContains(matr, randNumber)) 
                    randNumber = new Random().Next(10, 100);

                matr[i, j, k] = randNumber;
            }
}

bool MatrixContains(int[,,] matr, int randNumber)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(2); k++)
                if(matr[i, j, k] == randNumber) return true;
    return false;
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k], 2} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[x, y, z];

FillArray(matrix);
PrintArray(matrix);

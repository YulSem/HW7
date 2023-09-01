// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows, columns];

// for (int i=0; i<matrix.GetLength(0); i++)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(-100,100)/10.0;
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [m,n];

// for (int i=0; i<matrix.GetLength(0); i++)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(0,20);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
//  Console.WriteLine();

//  Console.WriteLine("Введите позицию элемента");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m || b>n)
//  Console.WriteLine("Такого числа нет");
//  else
//  {
//  Console.WriteLine("Значение искомого элемента "+matrix[a,b]);
//  }

//  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите первую размерность");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую размерность");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows, columns];

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().Next(0,20);
        Console.Write(matrix[i,j]+" ");
    }
     Console.WriteLine();
}
double[] averages = new double[columns];
for (int col = 0; col < columns; col++)
        {
            double sum = 0;
            
            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row, col];
            }
            
            averages[col] = sum / rows;
        }
        
        for (int col = 0; col < columns; col++)
        {
            Console.WriteLine($"Среднее арифметическое столбца {col + 1}: {averages[col]}");
        }
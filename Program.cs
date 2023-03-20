// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] ReverseArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     for (int k = i+1; k < array.GetLength(0); k++)
//     {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[j,i] < array[j,k]) 
//             {
//             int temp = array[j,i];
//             array[j,i] = array[j,k];
//             array[j,k] = temp;
//             }
//         }
// }
//     return array;
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = ReverseArray(myArray);
// Show2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumRows1 (int[,] array)
// {
//     int sum = 0;
//     int i = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//     {
//         {
//             sum = sum + array[i, j];
//         }
//     }
//     return sum;
// }

// int MinRows (int[,] array, int sum1)
// {
//     int sum = 0;
//     int count = 0;
//      for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if (sum < sum1) 
//         {
//             sum1 = sum;
//             count = i;
//         }
//         sum = 0;
//     }
//     return count+1;
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// int sum1 = SumRows1 (myArray);
// int minrows = MinRows (myArray, sum1);
// Console.Write($"{minrows} строка");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] FirstMatrix (int a, int b, int minValue, int maxValue)
// {
//     int[,] newArray = new int[a, b];

//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // x = i
// // y = j

// int[,] SecontMatrix(int a, int c, int minValue, int maxValue)
// {
//     int[,] newArray2 = new int[c, a];

//     for (int y = 0; y < a; y++)
//     {
//         for (int j = 0; j < c; j++)
//         {
//             newArray2[y, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }
//     return newArray2;
// }

// void Show2DArray2(int[,] array2)
// {
//     for (int y = 0; y < array2.GetLength(0); y++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             Console.Write(array2[y, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Resultmatrix (int[,] myArray, int[,] myArray2, int a, int b)
// {
//     int[,] result = new int[a, b];

//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray2.GetLength(1); j++)
//         {
//             for (int y = 0; y < myArray2.GetLength(0); y++)
//             {
//              result [i, j] += myArray[i, y] * myArray2[y, j];
//             }
//         }
//     }
//     return result;
//  }

// Console.WriteLine("Input number of rows matrix1 = columns matrix 2");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns matrix 1");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of rows matrix 2");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input minimal value of matrix");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of matrix");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = FirstMatrix(a,b,minValue,maxValue);
// Show2DArray(myArray);

// int[,] myArray2 = SecontMatrix(c,a,minValue,maxValue);
// Show2DArray2(myArray2);

// int[,] myArray3 = Resultmatrix(myArray,myArray2, a, b);
// Show2DArray2(myArray3);

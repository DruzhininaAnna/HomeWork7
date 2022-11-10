// Домашняя работа к уроку 7

////////////////////////////////////////////////////////////////////////////////////////
/*
// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Павел, не смогла найти где мы проходили рандом вещественных чисел.
// если это можно сделать проще, подскажите пожалуйста как.
// (чтобы и целая часть числа была и дробная)

double[,] CreateRandomDoubleArray() // Создание вещественного двумерного массива
{
     Console.Write("Введите количество (M) строк массива ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите количество (N) столбцов массива");
     int columns = Convert.ToInt32(Console.ReadLine());
     double[,] array = new double[rows,columns];

     for(int i = 0; i < rows; i++)
          for(int j = 0; j < columns; j++)
               array[i,j] = Math.Round((new Random().NextDouble()),2) + new Random().Next(-9, 10);
     return array;
}

void Show2dDoubleArray(double[,] array) // Вывод на экран заданного двумерного массива
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
          for(int j = 0; j < array.GetLength(1); j++)
               Console.Write(array[i, j] + "\t");
          Console.WriteLine();
     }
}

double[,] array = CreateRandomDoubleArray();
Show2dDoubleArray(array);
*/

/////////////////////////////////////////////////////////////////////////////////////////
/*
// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandomIntArray() // Создание целочисленного двумерного массива
{
     Console.Write("Введите количество (M) строк массива: ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите количество (N) столбцов массива: ");
     int columns = Convert.ToInt32(Console.ReadLine());
     int[,] array = new int[rows,columns];
     for(int i = 0; i < rows; i++)
          for(int j = 0; j < columns; j++)
               array[i,j] = new Random().Next(1, 10);
     return array;
}

void Show2dIntArray(int[,] array) // Вывод на экран заданного двумерного массива
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
          for(int j = 0; j < array.GetLength(1); j++)
               Console.Write(array[i, j] + "\t");
          Console.WriteLine();
     }
}

void ShowVolue(int[,] array) // Вывод заданного элемента на экран
{
     Console.WriteLine("Введите позицию нужного элемента: ");
     Console.Write("Номер строки: ");
     int i = Convert.ToInt32(Console.ReadLine());
     Console.Write("Номер столбца: ");
     int j = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Значение элемента: " + array[i-1,j-1]);
}

int[,] arrayTask2 = CreateRandomIntArray();
Show2dIntArray(arrayTask2);
Console.WriteLine();
ShowVolue(arrayTask2);
*/
/////////////////////////////////////////////////////////////////////////////////////////

// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomIntArray() // Создание целочисленного двумерного массива
{
     Console.Write("Введите количество (M) строк массива: ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите количество (N) столбцов массива: ");
     int columns = Convert.ToInt32(Console.ReadLine());
     int[,] array = new int[rows,columns];
     for(int i = 0; i < rows; i++)
          for(int j = 0; j < columns; j++)
               array[i,j] = new Random().Next(1, 10);
     return array;
}

void Show2dIntArray(int[,] array) // Вывод на экран заданного двумерного массива
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
          for(int j = 0; j < array.GetLength(1); j++)
               Console.Write(array[i, j] + "\t");
          Console.WriteLine();
     }
}

double[] FindArithmeticMean(int[,] array) // Создание одномерного массива где элементы его 
                                          //- это среднее арифметическое каждого столбца двумерного массива
{
     double[] arrayMeanArifm = new double[array.GetLength(1)];
     for(int i = 0; i < array.GetLength(1); i++)
     {
          double sum = 0;
          for(int j = 0; j < array.GetLength(0); j++) sum += array[j,i];
          arrayMeanArifm[i] = Math.Round((sum / array.GetLength(1)),1);
     }
     return arrayMeanArifm;
}

void ShowArray(double[] array) // Вывод на экран одномерного массива
{
     for(int i = 0; i < array.Length-1; i++)
          Console.Write(array[i] + "; ");
     Console.Write(array[array.Length-1] + " ");     
}

int[,] intArray = CreateRandomIntArray();
double[] arithmeticMeanColumns = FindArithmeticMean(intArray);
Show2dIntArray(intArray);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
ShowArray(arithmeticMeanColumns);
Console.WriteLine();


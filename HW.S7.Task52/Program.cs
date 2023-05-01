// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Метод, заполняющий двумерный массив случайными числами.
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
  int[,] matr = new int[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      matr[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matr;
}

// Метод, печатающий двумерный массив.
void Print2DArr(int[,] matr)
{

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]}\t");
    }
    Console.WriteLine();
  }
}

// Метод вывода одномерного массива (вещест.числа).
void Print1DArr(double[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + "\t");
  }
  Console.WriteLine(arr[arr.Length - 1]);
}

// Метод нахождения ср.арифмет. в каждом столбце.
double[] ColMean(int[,] arr)
{
  double[] mean = new double[arr.GetLength(1)];
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      mean[j] += arr[i, j];
    }
    mean[j] = Math.Round(mean[j] / arr.GetLength(0), 2);
  }
  return mean;
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
double[] meanSum = ColMean(arr2D);
Console.WriteLine("Среднее арифметическое значние элементов в каждом столбце: ");
Print1DArr(meanSum);
// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

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

// Метод обнаружения строки с меньшей суммой эл-ов.
int MinSunRow(int[,] arr)
{
  int outM = 0;
  int minSum = int.MaxValue;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int sumRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sumRow += arr[i, j];
    }
    if (sumRow < minSum)
    {
      minSum = sumRow;
      outM++;
    }
  }
  return outM;
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
int rowN = MinSunRow(arr2D);
Console.WriteLine($"Строка №{rowN} содержит наименьшую сумму эл-ов.");


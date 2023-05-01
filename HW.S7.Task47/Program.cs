// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Метод заполнения массива вещественными числами в двумерном массиве.
double[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
  Random rnd = new Random();
  double[,] matr = new double[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      matr[i, j] = Math.Round(rnd.NextDouble() * 100, 2); //NextDouble - дает случайное вещественное число
    }
  }
  return matr;
}

// Метод, печатающий двумерный массив.
void Print2DArr(double[,] matr)
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

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
double[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
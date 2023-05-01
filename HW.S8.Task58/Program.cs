// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// Метод перемножения матриц.
int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
  if (matr1.GetLength(1) != matr2.GetLength(0)) throw new Exception("Умножение невозможно.");

  int[,] multiMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
  for (int i = 0; i < matr1.GetLength(0); i++)
  {
    for (int j = 0; j < matr2.GetLength(1); j++)
    {
      for (int k = 0; k < matr2.GetLength(0); k++)
      {
        multiMatr[i, j] += matr1[i, k] * matr2[k, j];
      }
    }
  }
  return multiMatr;
}

int row = ReadData("Введите кол-во строк для матрицы A: ");
int col = ReadData("Введите кол-во столбцов для матрицы A: ");
int row2 = ReadData("Введите кол-во строк для матрицы B: ");
int col2 = ReadData("Введите кол-во столбцов для матрицы B: ");
int[,] matrix = Gen2DArray(row, col, 1, 10);
int[,] matrix2 = Gen2DArray(row2, col2, 1, 10);
Print2DArr(matrix);
Console.WriteLine();
Print2DArr(matrix2);
Console.WriteLine();
int[,] multiMatrix = MultiplicationMatrix(matrix, matrix2);
Print2DArr(multiMatrix);


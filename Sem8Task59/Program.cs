// Задача №59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен наименьший элемент массива.

//Метод читает данные от пользователя
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

// Метод нахождения индесков минимального эл-та.
int[] FindMinElm(int[,] mtr)
{
  int[] outA = new int[2];
  int minElm = int.MaxValue;
  for (int i = 0; i < mtr.GetLength(0); i++)
  {
    for (int j = 0; j < mtr.GetLength(1); j++)
    {
      if (minElm > mtr[i, j])
      {
        minElm = mtr[i, j];
        outA[0] = i;
        outA[1] = j;
      }
    }
  }
  return outA;
}

// Метод, который удаляет строку и столбец, где находится минимальный эл-т
int[,] ReGen2DArr(int[,] matr, int[] point)
{
  int[,] outM = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
  int k = 0;
  int m = 0;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    m = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (i != point[0] && j != point[1])
      {
        outM[k, m] = matr[i, j];
        m++;
      }
    }
    if (i != point[0])
    {
      k++;
    }
  }
  return outM;
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
int[] point = FindMinElm(arr2D);
int[,] outMatr = ReGen2DArr(arr2D, point);
Console.WriteLine();
Print2DArr(outMatr);
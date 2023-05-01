// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

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

// Метод, упорядовачивающий эл-ты массива по убыванию.
void SortArr(int[,] matr)
{
  int[] buff = new int[matr.GetLength(1)];

  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      buff[j] = matr[i, j];
    }

    // Сортировка вставкой.
    for (int n = 1; n < matr.GetLength(1); n++)
    {
      int k = buff[n];
      int m = n - 1;
      while (m >= 0 && buff[m] < k)
      {
        buff[m + 1] = buff[m];
        buff[m] = k;
        m--;
      }

    }
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = buff[j];
    }
  }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
Console.WriteLine();
SortArr(arr2D);
Print2DArr(arr2D);
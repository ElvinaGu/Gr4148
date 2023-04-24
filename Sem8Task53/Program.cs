// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю
// строку массива.

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

// Метод, меняющий местами первую и последнюю строку массива.
void Change2DArray(int[,] matr)
{
  int temp=0;
  for(int i =0;i<matr.GetLength(1);i++)
  {
    temp = matr[0,i];
    matr[0,i]=matr[matr.GetLength(1)-1,i];
    matr[matr.GetLength(1)-1,i]=temp;
  }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 50);
Print2DArr(arr2D);
Change2DArray(arr2D);
Console.WriteLine();
Print2DArr(arr2D);
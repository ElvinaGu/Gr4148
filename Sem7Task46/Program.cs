// Задача №46
// Задайте двумерный массив размером mxn, заполненный случайными целыми числами.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Метод, заполняющий двумерный массив случайными числами
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

// Метод, печатающий двумерный разноцветный массив
void Print2DArr(int[,] matr)
{
  ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black,ConsoleColor.Blue,
                                          ConsoleColor.Cyan,ConsoleColor.DarkBlue,
                                          ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                          ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,
                                          ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
                                          ConsoleColor.Gray,ConsoleColor.Green,
                                          ConsoleColor.Magenta,ConsoleColor.Red,
                                          ConsoleColor.White,ConsoleColor.Yellow};
                                          
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0, 16)];
      Console.Write($"{matr[i, j]} ");
      Console.ResetColor();
    }
    Console.WriteLine();
  }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);
Print2DArr(arr2D);
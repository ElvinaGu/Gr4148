// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Метод, заполняющий двумерный массив по формуле: Aₘₙ = m+n
int[,] FillNM2DArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = i + j;
    }
  }
  return arr;
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
int[,] arr2D = new int[row, col];
int[,] arr = FillNM2DArray(arr2D);
Print2DArr(arr);
// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
// эта точка.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

// Метод определяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
  if (x > 0 && y > 0) Console.WriteLine("Точка в 1-й четверти");
  if (x > 0 && y < 0) Console.WriteLine("Точка в 2-й четверти");
  if (x < 0 && y < 0) Console.WriteLine("Точка в 3-й четверти");
  if (x < 0 && y > 0) Console.WriteLine("Точка в 4-й четверти");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);
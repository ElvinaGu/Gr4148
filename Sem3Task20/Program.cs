//Задача №20
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}
double CalcLen2D(int x1, int y1, int x2, int y2)
{
  return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1 - y2) * (y1 - y2));
}
// Запрос координат
int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");

Console.WriteLine("Расстояние между точками A и B: " + CalcLen2D(x1, y1, x2, y2));
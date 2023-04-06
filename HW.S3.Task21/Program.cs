// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод расчета расстояния между точками
double CalcLen3D(int xA, int yA, int zA, int xB, int yB, int zB)
{
  return Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
}
// Запрос координат
int xA = ReadData("Введите координату x точки A: ");
int yA = ReadData("Введите координату y точки A: ");
int zA = ReadData("Введите координату z точки A: ");
int xB = ReadData("Введите координату x точки B: ");
int yB = ReadData("Введите координату y точки B: ");
int zB = ReadData("Введите координату z точки B: ");

Console.WriteLine("Расстояние между точками A и B: " + CalcLen3D(xA, yA, zA, xB, yB, zB));
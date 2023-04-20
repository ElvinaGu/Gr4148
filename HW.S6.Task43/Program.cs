// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

//Метод читает данные от пользователя
double ReadData(string msg)
{
  Console.Write(msg);
  double res = double.Parse(Console.ReadLine() ?? "0");
  return res;
};

//Метод обнаружения точки пересечения прямых
string CoordIntersecPoint(double pB1, double pK1, double pB2, double pK2)
{
  string point = "";
  double x = 0;
  double y = 0;
  if (pK1 == pK2)
  {
    return ("Прямые параллельны");
  }
  else
  {
    x = Math.Round((pB2 - pB1) / ((pK1 - pK2)), 2); //преобразованное уравнение
    y = Math.Round(pK1 * x + pB1, 2);
    point = point + x + "; " + y;
    return point;
  }

}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");
string z = CoordIntersecPoint(b1, k1, b2, k2);
Console.WriteLine("Координаты точки пересечения Z: " + z);
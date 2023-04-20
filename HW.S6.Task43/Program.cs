// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

//Метод обнаружения точки пересечения прямых
string CoordIntersecPoint(int pB1, int pK1, int pB2, int pK2)
{
  string point = "";
  int x = 0;
  int y = 0;
  if (pK1 == pK2)
  {
    return ("Прямые параллельны");
  }
  else
  {
    x = (pB2 - pB1) / ((pK1 - pK2)); //преобразованное уравнение
    y = pK1 * x + pB1;
    point = point + x + ";" + y;
    return point;
  }

}

int b1 = ReadData("Введите значение b1: ");
int k1 = ReadData("Введите значение k1: ");
int b2 = ReadData("Введите значение b2: ");
int k2 = ReadData("Введите значение k2: ");
string z = CoordIntersecPoint(b1, k1, b2, k2);
Console.WriteLine("Координаты точки пересечения Z: " + z);
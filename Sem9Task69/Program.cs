// 69 Напишите прграмму, которая будет принимать 2 числа А и В и
// возведите А в степень В с помощью рекурсии

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсивный метод возведения числа A в степень B.
long RecPow(int a, int b)
{
  if (b > 0)
  {
    return a * RecPow(a, b - 1);
  }
  else return 1;
}

long MyRecPow(int a, int b)
{
  if (b == 2)
  {
    return 4;
  }
  else
  {
    return MyRecPow(a, b / 2) * MyRecPow(a, b / 2);
  }
}

int a = ReadData("Введите число A: ");
int b = ReadData("Введите число B: ");
DateTime d1 = DateTime.Now;
Console.WriteLine(RecPow(a, b));
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
Console.WriteLine(MyRecPow(a, b));
Console.WriteLine(DateTime.Now - d2);
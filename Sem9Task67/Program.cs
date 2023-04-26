// Задача 67
// примает на вход число и возвращает сумму числа

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсивный метод вычисления суммы числа
int SumDigRec(int n)
{
  if (n > 0)
  {
    return n % 10 + SumDigRec(n / 10);
  }
  else
  {
    return 0;
  }
}

int num = ReadData("Введите число: ");
Console.WriteLine(SumDigRec(num));
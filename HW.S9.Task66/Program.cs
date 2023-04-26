// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсивный метод подсчета суммы эл-ов в промежутке от M до N.
int RecSumMN(int m, int n)
{
  if (m >= n) return n;
  else return m + RecSumMN(m + 1, n);
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// Защита от "дурака".
if (m > n)
{
  int temp = m;
  m = n;
  n = temp;
}

Console.WriteLine($"Сумма эл-ов в промежутке от M до N: {RecSumMN(m, n)}");
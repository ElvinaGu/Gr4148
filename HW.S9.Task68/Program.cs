// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсионный метод. Ф-ция Аккермана.
int Ackermann(int m, int n)
{
  if (m == 0) return n + 1;
  if ((m != 0) && (n == 0)) return Ackermann(m - 1, 1);
  if ((m > 0) && (n > 0)) return Ackermann(m - 1, Ackermann(m, n - 1));
  return Ackermann(m, n);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
Console.WriteLine($"Вычисление по ф-ции Аккермана: {Ackermann(numM, numN)}");
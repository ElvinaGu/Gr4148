// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсионный метод. Числа от N до 1
void LineGenRec(int numN)
{
  Console.Write(numN + " ");
  if (numN <= 1)
  {
  }
  else
  {
    LineGenRec(numN - 1);
  }
}

int num = ReadData("Введите число N: ");
LineGenRec(num);

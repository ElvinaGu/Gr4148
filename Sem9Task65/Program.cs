// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы 
// в промежутке от M до N.

// Метод читает данные от пользователя.
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

// Рекурсия. Числа от M до N.
string RecMN(int m, int n)
{
  if (m <= n)
  {
    return m + " " + RecMN(m + 1, n);
  }
  else
  {
    return String.Empty;
  }
}

int num = ReadData("Введите число M: ");
int num2 = ReadData("Введите число N: ");

// Защита от "дурака".
if (num > num2)
{
  int temp = num;
  num = num2;
  num2 = temp;
}


Console.WriteLine(RecMN(num, num2));
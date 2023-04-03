// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg, BigInteger res)
{
  Console.WriteLine(msg + res);
}

//Метод нахождения факториала
BigInteger Factorial(int number)
{
  BigInteger result = 1;
  for (int i = 1; i <= number; i++)
  {
    result = result * i;
  }
  return result;
}

int numA = ReadData("Введите число: ");
BigInteger res1 = Factorial(numA);
PrintResult("Произведение чисел: ", (BigInteger)res1);

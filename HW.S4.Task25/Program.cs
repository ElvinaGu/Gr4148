// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg, long res)
{
  Console.WriteLine(msg + res);
}

//Метод возведения числа в степень др.числа
long Exponentiation(int numberA, int numberB)
{
  int res = 0;
  res = (int)Math.Pow(numberA, numberB);
  return res;
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
PrintResult("Число A в степени B: ", Exponentiation(numA, numB));
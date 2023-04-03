// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg, long res)
{
  Console.WriteLine(msg + res);
}

//Метод подсчета цифр
long CountDigit(long num)
{
  int res = 0;
  //res=(long)Math.Log(num)+1;
  while (num > 0)
  {
    res = res + 1;
    num = num / 10;
  }
  return res;
}

long numberA = ReadData("Введите число: ");
long res1 = CountDigit(numberA);
PrintResult("Количеств цифр: ", (long)res1);
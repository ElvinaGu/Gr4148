// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg, int res)
{
  Console.WriteLine(msg + res);
}

//Метод суммирования цифр в числе
int digitSum(int number)
{
  int sum = 0;
  while (number > 0)
  {
    sum += number % 10;
    number = number / 10;
  }
  return sum;
}

int num1 = ReadData("Введите число: ");
PrintResult("Сумма цифр в числе: ", (digitSum(num1)));
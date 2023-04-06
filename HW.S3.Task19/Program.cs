// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg)
{
  Console.WriteLine(msg);
}

//Метод проверки на палиндром
bool PalTes(int num)
{
  bool res = false;
  int d1 = num / 10000;
  int d5 = num % 10;
  int d2 = (num / 1000) % 10;
  int d4 = (num / 10) % 10;

  if (d1 == d5 && d2 == d4)
  {
    res = true;
  }
  return res;
}

int number = ReadData("Введите пятизначное число: ");

//Проверка на пятизначность положительного числа
if (number >= 100000 || number < 10000)
{
  PrintResult("Неверный ввод. Введите пятизначное число");
}
else
{
  bool answer = PalTes(number);
  if (answer == true) PrintResult("Число " + number + " является палиндромом");
  if (answer == false) PrintResult("Число " + number + " не является палиндромом");
}
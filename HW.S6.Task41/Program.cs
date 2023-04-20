// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
};

//Метод подсчета кол-ва чисел >0
int CountPosNum(int num)
{
  int count = 0;
  while (num > 0)
  {
    int val = ReadData("Введите число: ");
    if (val > 0) count++;
    num = num - 1;
  }
  return count;
}

int quanNum = ReadData("Введите количество планируемых для ввода чисел: ");
int res = CountPosNum(quanNum);
Console.WriteLine("Кол-во чисел больше 0: " + res);
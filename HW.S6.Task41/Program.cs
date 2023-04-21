using System.Text.RegularExpressions;
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

// * Пользователь вводит число нажатий, затем программа следит за нажатиями 
// и выдает сколько чисел больше 0 было введено.

int taps = ReadData("Введите количество нажатий: ");
string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
Console.WriteLine(inputLine);
FindNumbersInString(inputLine, taps);

//метод считывает нажатие клавиш на клавиатуре заданное количество раз 
// и собирает данные в строку через запятую
string ReadLineData(string msg)
{
  Console.WriteLine(msg);
  string line = "";
  for (int i = 0; i < taps; i++)
  {
    var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
    line = line + String.Format(key.KeyChar.ToString()) + ",";
  }
  line = line.TrimEnd(','); //кусь последнюю запятую
  return line;
}

// Метод для поиска десятичных цифр в строке с помощью регулярных выражений
void FindNumbersInString(string str, int count)
{
  Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
  MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
  int posNums = 0;
  if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
  {
    foreach (Match match in matches)
    {
      posNums = posNums + 1;
    }
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
  }
  else
  {
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
  }
}


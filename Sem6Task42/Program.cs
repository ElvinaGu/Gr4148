// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод преобразования из десятичной в двоичную с/с
string DecToBin(int num)
{
  string res = String.Empty;
  while (num > 0)
  {
    res = res + num % 2;
    num = num / 2;
  }
  return res;
}

int dec = ReadData("Введите десятичное число: ");
string res = "";
res = DecToBin(dec);
Console.WriteLine("Число в двоичном виде: " + res);

Console.WriteLine(Convert.ToString(dec, 2)); // преобразование в двоичную с/c
Console.WriteLine(Convert.ToString(dec, 8)); // преобразование в восьмиричную с/c
Console.WriteLine(Convert.ToString(dec, 16)); // преобразование в шестнадцатиричную с/c
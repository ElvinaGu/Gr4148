// Задача №22
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод генерации
string LineGen(int num, int pow)
{
  string result = String.Empty;

  for (int i = 1; i <= num; i++)
  {
    result = result + Math.Pow(i, pow) + "_";
  }
  return result;
}

int numN = ReadData("Введите число N: ");
Console.WriteLine(LineGen(numN,1));
Console.WriteLine(LineGen(numN,2));
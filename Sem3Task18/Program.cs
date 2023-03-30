// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();
//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

// печатаем тест четверти
void PrintAnswer(int num)
{
  if (num == 1) Console.WriteLine("x>0, y>0");
  if (num == 2) Console.WriteLine("x>0, y<0");
  if (num == 3) Console.WriteLine("x<0, y<0");
  if (num == 4) Console.WriteLine("x<0, y>0");
}

int num = ReadData("Введите четверть 1-4: ");
if (num>5)Console.WriteLine("Нет такой четверти");
PrintAnswer(num);
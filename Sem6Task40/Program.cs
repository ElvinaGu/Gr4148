// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод проверки на существование треугольника со сторонами той или иной длины
void TrianTest(int a, int b, int c)
{
  if ((a <= b + c) && (b <= a + c) && (c <= a + b))
  {
    Console.WriteLine("Треугольник существует");
  }
  else
  {
    Console.WriteLine("Треугольник не существует");
  }
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
int numC = ReadData("Введите число C: ");
TrianTest(numA, numB, numC);

// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

Console.Clear();
//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результата
void PrintResult(string msg, int res)
{
  Console.WriteLine(msg + res);
}

//Простой метод суммирования чисел
long SumSimple(int numA)
{
  long sum = 0;
  for (int i = 1; i <= numA; i++)
  {
    sum += i; // sum=sum+i
  }
  return sum;
}

//Суммирование по методу Гаусса
long SumGauss(int numA)
{
  return((1+(long)numA)*(long)numA)/2;
}

int numberA = ReadData("Введите число A: ");
DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A (простой метод): ", (int)res1);
PrintResult("Сумма чисел от 1 до A (метод Гаусса): ", (int)res2);
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Напишите число ");
string? a1 = Console.ReadLine();
Console.Write("Напишите число ");
string? b1 = Console.ReadLine();

if (a1 != null && b1 != null)
{
  int a = int.Parse(a1);
  int b = int.Parse(b1);

  if (a > b)
  {
    Console.Write("Наибольшим числом является ");
    Console.WriteLine(a);
    Console.Write("Наименьшим числом является ");
    Console.WriteLine(b);
  }
  else
  {
    if (a == b)
    {
      Console.WriteLine("Числа равны");
    }
    else
    {
      Console.Write("Наибольшим числом является ");
      Console.WriteLine(b);
      Console.Write("Наименьшим числом является ");
      Console.WriteLine(a);
    }
  }
}
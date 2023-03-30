// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Напишите число ");
string? number = Console.ReadLine();

if (number != null)
{
  int Num1 = int.Parse(number);

  for (int i = 2; i <= Num1; i += 2)
  {
    Console.WriteLine(i);
  }
}
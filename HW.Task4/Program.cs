// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел

Console.Write("Напишите число ");
string? a1 = Console.ReadLine();
Console.Write("Напишите число ");
string? b1 = Console.ReadLine();
Console.Write("Напишите число ");
string? c1 = Console.ReadLine();

if (a1 != null && b1 != null && c1 != null)
{
  int a = int.Parse(a1);
  int b = int.Parse(b1);
  int c = int.Parse(c1);

  int max = a;
  if(b>max) max = b;
  if(c>max) max = c;
  Console.Write("Максимальное число ");
  Console.WriteLine(max);
}
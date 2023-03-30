// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)

Console.Write("Напишите число ");
string? a1 = Console.ReadLine();

if (a1 != null)
{
  int a = int.Parse(a1);
  if (a % 2 == 0)
  {
    Console.WriteLine("Число является четным");
  }
  else
  {
    Console.WriteLine("Число НЕ является четным");
  }
}
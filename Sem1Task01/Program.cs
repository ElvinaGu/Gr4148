// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

string? numberA = Console.ReadLine();
string? numberB = Console.ReadLine();

if (numberA != null && numberB != null)
{
  int numA = int.Parse(numberA);
  int numB = int.Parse(numberB);

  if (numA == numB * numB)
  {
    Console.WriteLine("Первое число является квадратом вторго числа!");
  }
  else
  {
    Console.WriteLine("Первое число НЕ является квадратом второго числа!");
  }
}


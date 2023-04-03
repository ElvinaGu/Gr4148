// // Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

int num = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (num % 7 == 0);
bool test2 = (num % 23 == 0);
// && - "и"; || - "или"
if (test1 && test2)
{
  Console.WriteLine("Число кратно 7 и 23");
}
else
{
  Console.WriteLine("Число не кратно 7 и 23");
}
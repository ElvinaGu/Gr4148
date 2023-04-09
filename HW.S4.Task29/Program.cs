// Задача 29: Напишите программу, которая задаёт массив из 
//8 элементов и выводит
// их на экран.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод заполнения массива
int[] Gen1DArr(int len)
{
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(1, 100);
  }
  return arr;
}

//Метод вывода результата
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

int digArr = ReadData("Введите длину массива: ");
int[] genArr = Gen1DArr(digArr);
Print1DArr(genArr);

// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).

Console.Write("Введите имена через запятую: ");
string ollNames = (Console.ReadLine() ?? "0");
//Разделение строки на отдельные эл-ты
string[] subs = ollNames.Split(',', ' ');
Random rnd = new Random();
int len = rnd.Next(1, subs.Length + 1);

Console.WriteLine("Посуду сегодня моет: " + subs[len]);





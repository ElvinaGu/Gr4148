// Задача №33
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
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

//Метод заполнения массива
int[] Gen1DArr(int len, int top, int but) //top - макс. значение эл-та; but - мин.
{
  if (but > top)
  {
    int buf = but;
    but = top;
    top = buf;
  }
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(but, top + 1);
  }
  return arr;
}

//Метод поиска необходимого эл-та
void SearchElm(int elmt, int[] arr)
{
  bool elmtFind = false;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == elmt)
    {
      Console.WriteLine("Элемент найден");
      elmtFind = true;
      break;
    }
  }
  if (elmtFind != true)
  {
    Console.WriteLine("Элемент не найден");
  }
}

int[] arr = Gen1DArr(5, 7, -9);
Print1DArr(arr);
int num = ReadData("Введите элемент, который необходимо найти: ");
SearchElm(num, arr);
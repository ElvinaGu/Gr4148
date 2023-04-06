// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

//Мед нахождения количества необходимых эл-ов
int ElmInRange(int[] arr, int min, int max) //min и max - значения определенного отрезка
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > min && arr[i] < max)
    {
      res++;
    }
  }
  return res;
}

int[] arr = Gen1DArr(123, 110, 0);
Print1DArr(arr);
int res = ElmInRange(arr, 10, 99);
Console.WriteLine("Количество элементов в промежутке [10,99]: " + res);

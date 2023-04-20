// Задача №39
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//Метод заполнения массива двухзначными положительными числами
int[] Gen1DArr(int len)
{
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(10, 100);
  }
  return arr;
}

//Метод вывода массива
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод разворота массива
void SwapArray(int[] arr)
{
  int buf = 0;
  for (int i = 0; i < arr.Length / 2; i++)
  {
    //(arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
    buf = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = buf;
  }
}

// Метод разворота массива
int[] SwapNewArray(int[] arr)
{
  int[] outArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    outArr[outArr.Length - 1 - i] = arr[i];
  }
  return outArr;
}

int[] testArray = Gen1DArr(120);
Print1DArr(testArray);
Console.WriteLine();
DateTime d1 = DateTime.Now;
int[] newArray = SwapNewArray(testArray);
DateTime d2 = DateTime.Now;
SwapArray(testArray);

Console.WriteLine("Сортировка методом создания нового массива заняла: " + (DateTime.Now - d1));
Print1DArr(newArray);
Console.WriteLine("Сортировка методом разворота без создания нового массива заняла: " + (DateTime.Now - d2));
Print1DArr(testArray);
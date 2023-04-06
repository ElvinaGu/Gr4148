// Задача №37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

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

//Метод произведения пар чисел
int[] ConvertArr(int[] arr)
{
  int len = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
  int[] outArr = new int[len];
  for(int i=0;i<len;i++)
  {
    outArr[i]=arr[i]*arr[arr.Length-1-i];
  }
  return outArr;
}

int [] arr = Gen1DArr(12,5,2);
Print1DArr(arr);
ConvertArr(arr);
Print1DArr(ConvertArr(arr));
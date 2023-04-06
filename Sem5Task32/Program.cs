// Задача №32
// Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.

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

//Метод замены эл-ов на их противоположные значения
void InversArr(int[] arr)
{
for(int i=0;i<arr.Length;i++)
{
  arr[i]=arr[i]*(-1);
}
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);
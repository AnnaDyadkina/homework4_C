//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

GetArray(GetParameter ("Введите длину массива"), GetParameter("Введите минимальное число"), GetParameter("Введите максимальное число"));

string PrintArray (int[] array) {
  string result = array[0].ToString();
  for (int i = 1; i < array.Length; i++)
  {
    result = result + ", " + array[i];
  }
  result = "[" + result + "]";
  return result;
}

void GetArray (int length, int min, int max)
{
  if (min < max && length > 0)
  {
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
      array[i] = new Random().Next(min, max+1);
    }
    Console.WriteLine(PrintArray(array));
  }
  else if (min > max && length > 0)
  {
    Console.WriteLine("Неверные минимальное и максимальное значение");
  }
  else if (min < max && length <= 0)
  {
    Console.WriteLine("Неверная длина массива");
  }
  else if (min > max && length <= 0)
  {
    Console.WriteLine("Неверно введены параметры массива");
  }
}

int GetParameter (string message)
{
  Console.WriteLine(message);
  int parameter = int.Parse(Console.ReadLine());
  return parameter;
}

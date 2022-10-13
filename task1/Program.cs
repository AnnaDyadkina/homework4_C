// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите число");
double InputNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int InputDegree = int.Parse(Console.ReadLine());
if (InputDegree < 0)
{
  Console.WriteLine("Введите положительное число");
}
else {
  Console.WriteLine(CalcDegree(InputNumber, InputDegree));
}

// int GetNumber (string message)
// {
//   Console.WriteLine(message);
//   double number = double.Parse(Console.ReadLine());
//   return number;
// }

double CalcDegree (double number, int degree)
{
  double result = number;
  if (degree > 0)
  {
    for (int i = 1; i < degree; i++)
    {
      result = result * number;
    }
  //  return result;
  }
  else if (degree == 0)
  {
    result = 0;
    //return result;
  }
  return result;
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int InputNumber = GetNumber("Введите число");
Console.WriteLine(CalcSum (InputNumber));

int CalcSum (int number)
{
  int sum = 0;
  number = Math.Abs(number);
  while(number > 0)
  {
    sum = sum + number % 10;
    number = number /= 10;
  }
  return sum;
}
int GetNumber (string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}

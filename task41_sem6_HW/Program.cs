// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine ("Введите числа через запятую:");
string number = Console.ReadLine();
string [] positivenumber = new string [number.Length];

int tmp = 0;
for (int i = 0; i < positivenumber.Length; i++)
{
  if (number[i] == ',')
  {
    tmp++;
  }
  else
  {
    positivenumber[tmp] = positivenumber[tmp] + $"{number[i]}";
  }
}
tmp++;

void PrintArray (int [] array, string [] evenCount)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(evenCount[i]);
  }
Console.WriteLine();
}

int [] resultnumber = new int[tmp];
PrintArray (resultnumber, positivenumber);
int count= 0;
for (int i = 0; i < tmp; i++)
{
  if (resultnumber[i] > 0)
  {
    count++;
  }
}
Console.WriteLine ("Count positive number: "+ count);
















// // Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// // Console.WriteLine($"количество значений больше 0 = {GetSumNums(sum)}");



// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum++;
//            }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// int num3 = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
// Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");
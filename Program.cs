int[] GetArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size, -50, 50);
int sum = 0;
for (int i = 1; i < size; i++)
{
  sum+=array[i];
  i++;
}
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве [ {String.Join(" ", array)} ] равна {sum} ");
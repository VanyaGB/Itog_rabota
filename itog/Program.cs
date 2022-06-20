/*Написать программу, к-ая из имеющегося массива строк формирует массив
из строк, длина к-ых меньше либо равна 3 символа. Первоначальный массив
можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите элемент массива под индексом {i}: ");
  array[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массива: ");

for (int i = 0; i < array.Length; i++)
{
  Console.Write(array[i]);
  if (i != array.Length - 1)
  {
    Console.Write(", ");
  }
}
Console.WriteLine();

Console.WriteLine("Новый массив: ");

for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3)
  {
    Console.Write(array[i] + " ");
  }
}
Console.WriteLine();
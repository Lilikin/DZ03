// Задача 2: 
// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"Чётных чисел в массиве: {count}");

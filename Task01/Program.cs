// Задача 1: 
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения 
// которых лежат в отрезке [20,90].

int size = 10;
int[] array = new int[size];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(101);
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 19 && array[i] < 91)
    {
        count++;
    }
}
Console.WriteLine($"В массиве: [{string.Join("; ", array)}]");
Console.WriteLine($"Элементов лежащих в отрезке [20,90]: {count}");
